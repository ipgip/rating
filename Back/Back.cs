using rating;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Back
{
    public partial class Back : Form
    {
        List<Answers> Ans;
        List<Questions> Quest;
        int Q;

        public Back()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Ans = LoadXML(dateTimePicker1.Value, dateTimePicker2.Value, out Q);
            Quest = LoadQ();
            // сомбобокс
            comboBox1.Items.Add($"Все вопросы");
            foreach (Questions q in Quest)
                comboBox1.Items.Add($"{q.Question}");
            comboBox1.SelectedIndex = 0;
        }

        private List<Questions> LoadQ()
        {
            List<Questions> ret = new List<Questions>();
            if (File.Exists(@"c:\temp\questions.xml"))
            {
                XDocument doc = XDocument.Load(@"c:\temp\questions.xml");
                foreach (XElement el in doc.Root.Descendants("Questions").Elements())
                {
                    ret.Add(new Questions(el.Value, Convert.ToInt32(el.Attribute("Answers").Value), Convert.ToBoolean(el.Attribute("Logical")?.Value ?? "false")));
                }
            }
            return ret;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ans = LoadXML(dateTimePicker1.Value, dateTimePicker2.Value, out Q);

            chart1.Titles.Clear();
            chart1.Titles.Add($"с {dateTimePicker1.Value.Date:dd.MM.yyyy} по {dateTimePicker2.Value.Date:dd.MM.yyyy}");
            chart1.Series.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < Q; i++)
                {
                    Series series = chart1.Series.Add($"{Quest[i].Question}");
                    var D1 = Ans.Where(x => x.QuestionNumber == i+1).GroupBy(x => x.A).Select(x => new { a1 = x.Average(y => y.A) });
                    foreach (var ddd in D1)
                    {
                        series.Points.AddY(ddd.a1);
                    }
                }
            }
            else
            {
                Series series = chart1.Series.Add($"{Quest[comboBox1.SelectedIndex-1].Question}");
                var D1 = Ans.Where(x => x.QuestionNumber == comboBox1.SelectedIndex).GroupBy(x => x.A).Select(x => new { a1 = x.Average(y => y.A) });
                foreach (var ddd in D1)
                {
                    series.Points.AddY(ddd.a1);
                }
            }
        }

        private List<Answers> LoadXML(DateTime value, DateTime value1, out int Questions)
        {
            List<Answers> ret = new List<Answers>();
            Questions = 0;
            if (File.Exists(@"c:\temp\rating.xml"))
            {
                XDocument doc = XDocument.Load(@"c:\temp\rating.xml");
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
    }
}
