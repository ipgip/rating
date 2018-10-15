using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Back
{
    public partial class Form1 : Form
    {
        List<Answers> Ans;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ans = LoadXML(dateTimePicker1.Value,dateTimePicker2.Value, out int Q);
            chart1.Titles.Clear();
            chart1.Titles.Add($"с {dateTimePicker1.Value.Date:dd.MM.yyyy} по {dateTimePicker2.Value.Date:dd.MM.yyyy}");
            chart1.Series.Clear();
            for (int i = 0; i < Q; i++)
            {
                Series series = chart1.Series.Add($"Вопрос {i + 1}");
                var D1 = Ans.Where(x => x.QuestionNumber == i).GroupBy(x => x.A).Select(x => new { a1 = x.Sum(y => y.A) });
                foreach (var ddd in D1)
                {
                    series.Points.AddY(ddd.a1);
                }
            }
        }

        private List<Answers> LoadXML(DateTime value,DateTime value1, out int Questions)
        {
            List<Answers> ret = new List<Answers>();
            Questions = 0;
            if (File.Exists("rating.xml"))
            {
                XDocument doc = XDocument.Load("rating.xml");
                foreach (XElement el in doc.Root.Elements()
                    .Where(x => Convert.ToDateTime(x.Attribute("Date").Value).Date >= value.Date
                            && Convert.ToDateTime(x.Attribute("Date").Value).Date <= value1.Date))
                {
                    Questions = el.Attributes().Count(x => x.Name.LocalName.Substring(0, 1) == "a");
                    foreach (var Att in el.Attributes().Where(x => x.Name.LocalName.Substring(0, 1) == "a"))
                    {
                        ret.Add(new Answers(Convert.ToDateTime(el.Attribute("Date").Value), Convert.ToInt32(Att.Name.LocalName.Substring(1)), Convert.ToInt32(Att.Value)));
                    }
                }
            }
            return ret;
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
                dateTimePicker2.Value = dateTimePicker1.Value;
        }

        //private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    int Question = cb.SelectedIndex + 1;

        //    chart1.Titles.Add($"Дата {dateTimePicker1.Value.Date:dd.MM.yyyy}");
        //    chart1.Series.Clear();
        //    for (int i = 0; i < Question; i++)
        //    {
        //        Series series = chart1.Series.Add($"Вопрос {i}");
        //        var D1 = Ans.Where(x => x.QuestionNumber == i).GroupBy(x => x.A).Select(x => new { a1 = x.Count() });
        //        foreach (var ddd in D1)
        //        {
        //            series.Points.AddY(ddd.a1);
        //        }
        //    }
        //}
    }
}
