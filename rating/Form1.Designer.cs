namespace rating
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftTop = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.PictureBox();
            this.RightTop = new System.Windows.Forms.PictureBox();
            this.Left = new System.Windows.Forms.PictureBox();
            this.Right = new System.Windows.Forms.PictureBox();
            this.LeftBottom = new System.Windows.Forms.PictureBox();
            this.Bottom = new System.Windows.Forms.PictureBox();
            this.RightBottom = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(610, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 328);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(657, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Send_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(610, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 137);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(610, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(191, 74);
            this.textBox1.TabIndex = 6;
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LeftTop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Top, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RightTop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Left, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Right, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LeftBottom, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Bottom, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.RightBottom, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 374);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LeftTop
            // 
            this.LeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftTop.Location = new System.Drawing.Point(3, 3);
            this.LeftTop.Name = "LeftTop";
            this.LeftTop.Size = new System.Drawing.Size(14, 14);
            this.LeftTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftTop.TabIndex = 3;
            this.LeftTop.TabStop = false;
            // 
            // Top
            // 
            this.Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top.Location = new System.Drawing.Point(23, 3);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(752, 14);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 4;
            this.Top.TabStop = false;
            // 
            // RightTop
            // 
            this.RightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTop.Location = new System.Drawing.Point(781, 3);
            this.RightTop.Name = "RightTop";
            this.RightTop.Size = new System.Drawing.Size(14, 14);
            this.RightTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightTop.TabIndex = 5;
            this.RightTop.TabStop = false;
            // 
            // Left
            // 
            this.Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left.Location = new System.Drawing.Point(3, 23);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(14, 328);
            this.Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Left.TabIndex = 6;
            this.Left.TabStop = false;
            // 
            // Right
            // 
            this.Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right.Location = new System.Drawing.Point(781, 23);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(14, 328);
            this.Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Right.TabIndex = 7;
            this.Right.TabStop = false;
            // 
            // LeftBottom
            // 
            this.LeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftBottom.Location = new System.Drawing.Point(3, 357);
            this.LeftBottom.Name = "LeftBottom";
            this.LeftBottom.Size = new System.Drawing.Size(14, 14);
            this.LeftBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftBottom.TabIndex = 8;
            this.LeftBottom.TabStop = false;
            // 
            // Bottom
            // 
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bottom.Location = new System.Drawing.Point(23, 357);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(752, 14);
            this.Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bottom.TabIndex = 9;
            this.Bottom.TabStop = false;
            // 
            // RightBottom
            // 
            this.RightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightBottom.Location = new System.Drawing.Point(781, 357);
            this.RightBottom.Name = "RightBottom";
            this.RightBottom.Size = new System.Drawing.Size(14, 14);
            this.RightBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightBottom.TabIndex = 10;
            this.RightBottom.TabStop = false;
            // 
            // Banner
            // 
            this.Banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Banner.Location = new System.Drawing.Point(3, 378);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(648, 71);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 7;
            this.Banner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox LeftTop;
        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox RightTop;
        private System.Windows.Forms.PictureBox Left;
        private System.Windows.Forms.PictureBox Right;
        private System.Windows.Forms.PictureBox LeftBottom;
        private System.Windows.Forms.PictureBox Bottom;
        private System.Windows.Forms.PictureBox RightBottom;
        private System.Windows.Forms.PictureBox Banner;
    }
}

