using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace rating
{
    public partial class Rating : Form
    {
        List<Questions> Q;
        FilterInfoCollection videodevices;
        VideoCaptureDevice device;
        Bitmap Snapshort = null;
        private Hashtable Decoration = new Hashtable();

        int[] A; // ответы

        public Rating()
        {
            InitializeComponent();
            Q = LoadQuestions();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Convert.ToBoolean(Decoration["Camera"] ?? false)) && (device.IsRunning))
                device.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region AForge
            if (Convert.ToBoolean(Decoration["Camera"] ?? false))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                videodevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                device = new VideoCaptureDevice();

                if (device.IsRunning)
                {
                    device.Stop();
                    pictureBox1.Image = null;
                    pictureBox1.Invalidate();
                }
                else
                {
                    device = new VideoCaptureDevice(videodevices[0].MonikerString);
                    device.NewFrame += CapturePicture;
                    //flg.Reset();
                    device.Start();
                }
            }
            #endregion
            #region Decor
            if (File.Exists(Decoration["LeftTop"]?.ToString()))
                LeftTop.Image = Image.FromFile(Decoration["LeftTop"].ToString());
            if (File.Exists(Decoration["Top"]?.ToString()))
                Top.Image = Image.FromFile(Decoration["Top"].ToString());
            if (File.Exists(Decoration["RightTop"]?.ToString()))
                RightTop.Image = Image.FromFile(Decoration["RightTop"].ToString());
            if (File.Exists(Decoration["Left"]?.ToString()))
                Left.Image = Image.FromFile(Decoration["Left"].ToString());
            if (File.Exists(Decoration["Right"]?.ToString()))
                Right.Image = Image.FromFile(Decoration["Right"].ToString());
            if (File.Exists(Decoration["LeftBottom"]?.ToString()))
                LeftBottom.Image = Image.FromFile(Decoration["LeftBottom"].ToString());
            if (File.Exists(Decoration["Bottom"]?.ToString()))
                Bottom.Image = Image.FromFile(Decoration["Bottom"].ToString());
            if (File.Exists(Decoration["RightBottom"]?.ToString()))
                LeftBottom.Image = Image.FromFile(Decoration["LeftBottom"].ToString());

            if (File.Exists(Decoration["Banner"]?.ToString()))
                Banner.Image = Image.FromFile(Decoration["Banner"].ToString());
            #endregion
            #region Ответы
            A = new int[Q.Count()];// ответы

            tableLayoutPanel1.RowCount = Q.Count();
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(
                    new RowStyle(
                        SizeType.Absolute,
                        (int)(tableLayoutPanel1.Height / tableLayoutPanel1.RowCount)));
            }
            int c = 0;
            foreach (Questions q in Q)
            {
                TableLayoutPanel Tp1 = new TableLayoutPanel()
                {
                    RowCount = 2,
                    ColumnCount = q.Answers,
                    Dock = DockStyle.Fill
                };
                Tp1.ColumnStyles.Clear();
                for (int i = 0; i < q.Answers; i++)
                {
                    //ColumnStyle C = new ColumnStyle(SizeType.Percent, 50f); //?????
                    ColumnStyle C = new ColumnStyle(SizeType.Percent, Tp1.Width / q.Answers); //?????
                    Tp1.ColumnStyles.Add(C);
                }
                for (int i = 0; i < Tp1.RowCount; i++)
                {
                    RowStyle R = new RowStyle(SizeType.Absolute, Tp1.Height / Tp1.RowCount);
                    Tp1.RowStyles.Add(R);
                }
                Tp1.Controls.Add(new Label()
                {
                    Text = q.Question,
                    Font = new Font(SystemFonts.DefaultFont.FontFamily, 14f, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                }, 0, 0);

                Tp1.SetColumnSpan(Tp1.GetControlFromPosition(0, 0), q.Answers);
                for (int i = 1; i < q.Answers + 1; i++)
                {
                    PictureBox p = new PictureBox
                    {
                       // Dock = (!q.Logical) ? DockStyle.None : (i == 1) ? DockStyle.Right : DockStyle.Left,
                        Image = Image.FromFile((!q.Logical) ?
                        (File.Exists(Decoration[$"B{i}"]?.ToString()) ? Decoration[$"B{i}"].ToString() : $"{i}.jpg") :
                        (File.Exists(Decoration[$"L{i}"]?.ToString()) ? Decoration[$"L{i}"].ToString() : $"l{i}.jpg")),
                        Name = $"{i}",
                        Tag = c,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    p.Click += P_Click;
                    Tp1.Controls.Add(p);
                }
                tableLayoutPanel1.Controls.Add(Tp1);
                c++;
            }
            #endregion
        }
        #region AForge
        private void CapturePicture(object sender, NewFrameEventArgs eventArgs)
        {
            Snapshort = (Bitmap)(eventArgs.Frame.Clone());
            pictureBox1.Image = Snapshort;
            //flg.Set();
        }
        #endregion

        private void P_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int Answer = int.Parse(p.Name.Substring(p.Name.Length - 1))/* + 1*/;
            if (A[Convert.ToInt32(p.Tag)] == 0)
            {
                A[Convert.ToInt32(p.Tag)] = Answer;
                MarkSelected(p);
            }

            button1.Enabled = CanFire(A);
            if (!timer1.Enabled)
                timer1.Start();
        }

        /// <summary>
        /// Отметка выбора
        /// </summary>
        /// <param name="p"></param>
        private void MarkSelected(PictureBox p)
        {
            //p.BorderStyle = BorderStyle.FixedSingle;
            //Graphics G = p.CreateGraphics();
            //G.DrawRectangle(Pens.Red, 0, 0, p.Width - 1, p.Height - 1);
            //G.Dispose();
            foreach (Control c in p.Parent.Controls)
            {
                if ((c.GetType() == typeof(PictureBox)) && (c != p))
                        c.Visible = false;
            }
            //p.Invalidate();
        }

        /// <summary>
        /// Отметка выбора
        /// </summary>
        /// <param name="p"></param>
        private void UnMarkSelected(PictureBox p)
        {
            //p.BorderStyle = BorderStyle.FixedSingle;
            //Graphics G = p.CreateGraphics();
            //G.DrawRectangle(Pens.White, 0, 0, p.Width - 1, p.Height - 1);
            //G.Dispose();
            foreach (Control c in p.Parent.Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                    c.Visible = true;
            }
            //p.Invalidate();
        }

        public List<Questions> LoadQuestions(string path = @"c:\temp\questions.xml")
        {
            List<Questions> ret = new List<Questions>();
            try
            {
                XDocument doc = XDocument.Load(path);
                // Загрузка декора
                foreach (XElement el in doc.Root.Descendants("Decoration").Elements())
                {
                    Decoration[el.Name.LocalName] = el.Value;
                }
                // Загрузка вопросов
                foreach (XElement el in doc.Root.Descendants("Questions").Elements())
                {
                    ret.Add(new Questions(
                        el.Value,
                        int.Parse(el.Attribute("Answers").Value.ToString()),
                        (el.Attribute("Logical") != null) ? Convert.ToBoolean(el.Attribute("Logical").Value) : false));
                }

            }
            catch (FileNotFoundException)
            {
                if (device.IsRunning)
                    device.Stop();
                Application.Exit();
            }
            return ret;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            if (timer2.Enabled)
                timer2.Stop();
            else
                timer2.Start();
            Renew();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (CanFire(A))
            {
                timer1.Stop();
                pictureBox2.Image = pictureBox1.Image;
                StringBuilder s = new StringBuilder();

                XElement e2 = new XElement("Rating", new XAttribute("Date", DateTime.Now))
                {
                    Value = (Convert.ToBoolean(Decoration["Camera"] ?? false)) ? ImgToStr(GetHashImage(pictureBox1.Image)) : ""
                };

                int i = 1;
                foreach (int A1 in A)
                {
                    XAttribute attr = new XAttribute($"a{i++}", $"{A1}");
                    e2.Add(attr);
                }
                if (File.Exists(@"c:\temp\rating.xml"))
                {
                    XDocument doc = XDocument.Load("Rating.xml");
                    doc.Root.Add(e2);
                    doc.Save(@"c:\temp\rating.xml");
                }
                else
                {
                    XDocument doc = new XDocument();
                    XElement e1 = new XElement("Ratings");
                    e1.Add(e2);
                    doc.Add(e1);
                    doc.Save(@"c:\temp\rating.xml");
                }
                timer2.Start();
                // передача на сервер
                // восстановление
                Renew();
            }
        }

        /// <summary>
        /// Восстановление фронта
        /// </summary>
        private void Renew()
        {
            //int i = 0;
            if (timer1.Enabled)
                timer1.Stop();
            if (timer2.Enabled)
                timer2.Stop();
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    TableLayoutPanel C1 = c as TableLayoutPanel;
                    foreach (Control cc in C1.Controls)
                        cc.Visible = true;
                    //int A1 = A[i++];
                    //if (A1 != 0)
                    //{
                    //    PictureBox pb = (PictureBox)C1.GetControlFromPosition(A1 - 1, 1);
                    //    UnMarkSelected(pb);
                    //    pb.BorderStyle = BorderStyle.None;
                    //}
                }
            }
            A = new int[Q.Count()]; // ответы
            button1.Enabled = CanFire(A);
        }

        /// <summary>
        /// Рфыр функция картинки
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        string GetHashImage(Image img)
        {
            // создаем объект этого класса. Отмечу, что он создается не через new, а вызовом метода Create
            MD5 md5Hasher = MD5.Create();

            // Преобразуем входную строку в массив байт и вычисляем хэш
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(ImgToStr(img)));

            // Создаем новый Stringbuilder (Изменяемую строку) для набора байт
            StringBuilder sBuilder = new StringBuilder();

            // Преобразуем каждый байт хэша в шестнадцатеричную строку
            for (int i = 0; i < data.Length; i++)
            {
                //указывает, что нужно преобразовать элемент в шестнадцатиричную строку длиной в два символа
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (RowStyle rs in tableLayoutPanel1.RowStyles)
            {
                rs.Height = (int)(tableLayoutPanel1.Height / tableLayoutPanel1.RowCount);
            }
        }

        private bool CanFire(int[] A)
        {
            int p = 1;
            foreach (int a1 in A)
                p *= a1;
            return (p != 0);
        }

        //функции преобразования изображения в строку
        public string ImgToStr(byte[] image)
        {
            string base64String;
            base64String = Convert.ToBase64String(image);
            return base64String;
        }

        public string ImgToStr(Image image)
        {
            string base64String;
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, ImageFormat.Jpeg);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public string ImgToStr(string image)
        {
            string base64String;
            //using (MemoryStream m = new MemoryStream())
            //{
            //image.Save(m, ImageFormat.Jpeg);
            //byte[] imageBytes = m.ToArray();
            //base64String = Convert.ToBase64String(imageBytes);
            base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes(image));
            return base64String;
            //}
        }
    }
}
