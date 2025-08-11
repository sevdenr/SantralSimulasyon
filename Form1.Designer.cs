namespace SantralSimülasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            Motor1 = new PictureBox();
            M3b1 = new PictureBox();
            Motor2 = new PictureBox();
            Motor3 = new PictureBox();
            kamyon = new PictureBox();
            mikserDurum = new PictureBox();
            mikserKapak = new PictureBox();
            kabin3 = new PictureBox();
            kabin2 = new PictureBox();
            kabin1 = new PictureBox();
            durdur = new PictureBox();
            baslat = new PictureBox();
            M3b2 = new PictureBox();
            M3b3 = new PictureBox();
            M3b4 = new PictureBox();
            M3b5 = new PictureBox();
            M2b2 = new PictureBox();
            M2b3 = new PictureBox();
            M2b4 = new PictureBox();
            M2b5 = new PictureBox();
            M2b1 = new PictureBox();
            M1b2 = new PictureBox();
            M1b3 = new PictureBox();
            M1b4 = new PictureBox();
            M1b5 = new PictureBox();
            M1b1 = new PictureBox();
            yukleme = new PictureBox();
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            k3deger = new Label();
            k2deger = new Label();
            k1deger = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Motor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M3b1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Motor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Motor3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kamyon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mikserDurum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mikserKapak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kabin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kabin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kabin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)durdur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baslat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M3b2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M3b3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M3b4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M3b5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M2b2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M2b3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M2b4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M2b5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M2b1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M1b2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M1b3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M1b4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M1b5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M1b1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yukleme).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Motor1
            // 
            Motor1.Image = (Image)resources.GetObject("Motor1.Image");
            Motor1.Location = new Point(12, 0);
            Motor1.Name = "Motor1";
            Motor1.Size = new Size(53, 45);
            Motor1.SizeMode = PictureBoxSizeMode.StretchImage;
            Motor1.TabIndex = 0;
            Motor1.TabStop = false;
            // 
            // M3b1
            // 
            M3b1.Image = Properties.Resources.Boru;
            M3b1.Location = new Point(71, 117);
            M3b1.Name = "M3b1";
            M3b1.Size = new Size(111, 10);
            M3b1.SizeMode = PictureBoxSizeMode.StretchImage;
            M3b1.TabIndex = 0;
            M3b1.TabStop = false;
            // 
            // Motor2
            // 
            Motor2.Image = (Image)resources.GetObject("Motor2.Image");
            Motor2.Location = new Point(12, 51);
            Motor2.Name = "Motor2";
            Motor2.Size = new Size(53, 45);
            Motor2.SizeMode = PictureBoxSizeMode.StretchImage;
            Motor2.TabIndex = 0;
            Motor2.TabStop = false;
            // 
            // Motor3
            // 
            Motor3.Image = Properties.Resources.MOTOROFF;
            Motor3.Location = new Point(12, 102);
            Motor3.Name = "Motor3";
            Motor3.Size = new Size(53, 45);
            Motor3.SizeMode = PictureBoxSizeMode.StretchImage;
            Motor3.TabIndex = 0;
            Motor3.TabStop = false;
            // 
            // kamyon
            // 
            kamyon.Image = Properties.Resources.Transmikser;
            kamyon.Location = new Point(672, 381);
            kamyon.Name = "kamyon";
            kamyon.Size = new Size(158, 108);
            kamyon.SizeMode = PictureBoxSizeMode.StretchImage;
            kamyon.TabIndex = 2;
            kamyon.TabStop = false;
            // 
            // mikserDurum
            // 
            mikserDurum.Image = Properties.Resources.Mikser2;
            mikserDurum.Location = new Point(595, 229);
            mikserDurum.Name = "mikserDurum";
            mikserDurum.Size = new Size(218, 110);
            mikserDurum.SizeMode = PictureBoxSizeMode.StretchImage;
            mikserDurum.TabIndex = 2;
            mikserDurum.TabStop = false;
            // 
            // mikserKapak
            // 
            mikserKapak.Image = Properties.Resources.MikserKapak;
            mikserKapak.Location = new Point(595, 229);
            mikserKapak.Name = "mikserKapak";
            mikserKapak.Size = new Size(218, 81);
            mikserKapak.SizeMode = PictureBoxSizeMode.StretchImage;
            mikserKapak.TabIndex = 0;
            mikserKapak.TabStop = false;
            // 
            // kabin3
            // 
            kabin3.BackColor = Color.White;
            kabin3.Image = Properties.Resources.bos;
            kabin3.Location = new Point(629, 153);
            kabin3.Name = "kabin3";
            kabin3.Size = new Size(31, 70);
            kabin3.SizeMode = PictureBoxSizeMode.StretchImage;
            kabin3.TabIndex = 0;
            kabin3.TabStop = false;
            // 
            // kabin2
            // 
            kabin2.BackColor = Color.White;
            kabin2.Image = (Image)resources.GetObject("kabin2.Image");
            kabin2.Location = new Point(687, 153);
            kabin2.Name = "kabin2";
            kabin2.Size = new Size(34, 70);
            kabin2.SizeMode = PictureBoxSizeMode.StretchImage;
            kabin2.TabIndex = 0;
            kabin2.TabStop = false;
            // 
            // kabin1
            // 
            kabin1.BackColor = Color.White;
            kabin1.Image = (Image)resources.GetObject("kabin1.Image");
            kabin1.Location = new Point(740, 153);
            kabin1.Name = "kabin1";
            kabin1.Size = new Size(35, 70);
            kabin1.SizeMode = PictureBoxSizeMode.StretchImage;
            kabin1.TabIndex = 0;
            kabin1.TabStop = false;
            // 
            // durdur
            // 
            durdur.Image = Properties.Resources.Kapa;
            durdur.Location = new Point(12, 427);
            durdur.Name = "durdur";
            durdur.Size = new Size(71, 62);
            durdur.SizeMode = PictureBoxSizeMode.StretchImage;
            durdur.TabIndex = 0;
            durdur.TabStop = false;
            durdur.Click += Durdur;
            // 
            // baslat
            // 
            baslat.Image = Properties.Resources.Ac;
            baslat.Location = new Point(12, 359);
            baslat.Name = "baslat";
            baslat.Size = new Size(71, 62);
            baslat.SizeMode = PictureBoxSizeMode.StretchImage;
            baslat.TabIndex = 0;
            baslat.TabStop = false;
            baslat.Click += Baslat;
            // 
            // M3b2
            // 
            M3b2.Image = (Image)resources.GetObject("M3b2.Image");
            M3b2.Location = new Point(179, 117);
            M3b2.Name = "M3b2";
            M3b2.Size = new Size(162, 10);
            M3b2.SizeMode = PictureBoxSizeMode.StretchImage;
            M3b2.TabIndex = 0;
            M3b2.TabStop = false;
            // 
            // M3b3
            // 
            M3b3.Image = (Image)resources.GetObject("M3b3.Image");
            M3b3.Location = new Point(335, 117);
            M3b3.Name = "M3b3";
            M3b3.Size = new Size(162, 10);
            M3b3.SizeMode = PictureBoxSizeMode.StretchImage;
            M3b3.TabIndex = 0;
            M3b3.TabStop = false;
            // 
            // M3b4
            // 
            M3b4.Image = (Image)resources.GetObject("M3b4.Image");
            M3b4.Location = new Point(488, 117);
            M3b4.Name = "M3b4";
            M3b4.Size = new Size(162, 10);
            M3b4.SizeMode = PictureBoxSizeMode.StretchImage;
            M3b4.TabIndex = 0;
            M3b4.TabStop = false;
            // 
            // M3b5
            // 
            M3b5.Image = (Image)resources.GetObject("M3b5.Image");
            M3b5.Location = new Point(640, 125);
            M3b5.Name = "M3b5";
            M3b5.Size = new Size(10, 22);
            M3b5.SizeMode = PictureBoxSizeMode.StretchImage;
            M3b5.TabIndex = 0;
            M3b5.TabStop = false;
            // 
            // M2b2
            // 
            M2b2.Image = (Image)resources.GetObject("M2b2.Image");
            M2b2.Location = new Point(179, 69);
            M2b2.Name = "M2b2";
            M2b2.Size = new Size(162, 10);
            M2b2.SizeMode = PictureBoxSizeMode.StretchImage;
            M2b2.TabIndex = 0;
            M2b2.TabStop = false;
            // 
            // M2b3
            // 
            M2b3.Image = (Image)resources.GetObject("M2b3.Image");
            M2b3.Location = new Point(335, 69);
            M2b3.Name = "M2b3";
            M2b3.Size = new Size(162, 10);
            M2b3.SizeMode = PictureBoxSizeMode.StretchImage;
            M2b3.TabIndex = 0;
            M2b3.TabStop = false;
            // 
            // M2b4
            // 
            M2b4.Image = (Image)resources.GetObject("M2b4.Image");
            M2b4.Location = new Point(488, 69);
            M2b4.Name = "M2b4";
            M2b4.Size = new Size(218, 10);
            M2b4.SizeMode = PictureBoxSizeMode.StretchImage;
            M2b4.TabIndex = 0;
            M2b4.TabStop = false;
            // 
            // M2b5
            // 
            M2b5.Image = (Image)resources.GetObject("M2b5.Image");
            M2b5.Location = new Point(696, 69);
            M2b5.Name = "M2b5";
            M2b5.Size = new Size(10, 78);
            M2b5.SizeMode = PictureBoxSizeMode.StretchImage;
            M2b5.TabIndex = 0;
            M2b5.TabStop = false;
            // 
            // M2b1
            // 
            M2b1.Image = Properties.Resources.Boru;
            M2b1.Location = new Point(71, 69);
            M2b1.Name = "M2b1";
            M2b1.Size = new Size(111, 10);
            M2b1.SizeMode = PictureBoxSizeMode.StretchImage;
            M2b1.TabIndex = 0;
            M2b1.TabStop = false;
            // 
            // M1b2
            // 
            M1b2.Image = (Image)resources.GetObject("M1b2.Image");
            M1b2.Location = new Point(179, 25);
            M1b2.Name = "M1b2";
            M1b2.Size = new Size(162, 10);
            M1b2.SizeMode = PictureBoxSizeMode.StretchImage;
            M1b2.TabIndex = 0;
            M1b2.TabStop = false;
            // 
            // M1b3
            // 
            M1b3.Image = (Image)resources.GetObject("M1b3.Image");
            M1b3.Location = new Point(335, 25);
            M1b3.Name = "M1b3";
            M1b3.Size = new Size(162, 10);
            M1b3.SizeMode = PictureBoxSizeMode.StretchImage;
            M1b3.TabIndex = 0;
            M1b3.TabStop = false;
            // 
            // M1b4
            // 
            M1b4.Image = (Image)resources.GetObject("M1b4.Image");
            M1b4.Location = new Point(488, 25);
            M1b4.Name = "M1b4";
            M1b4.Size = new Size(274, 10);
            M1b4.SizeMode = PictureBoxSizeMode.StretchImage;
            M1b4.TabIndex = 0;
            M1b4.TabStop = false;
            // 
            // M1b5
            // 
            M1b5.Image = (Image)resources.GetObject("M1b5.Image");
            M1b5.Location = new Point(752, 25);
            M1b5.Name = "M1b5";
            M1b5.Size = new Size(10, 122);
            M1b5.SizeMode = PictureBoxSizeMode.StretchImage;
            M1b5.TabIndex = 0;
            M1b5.TabStop = false;
            // 
            // M1b1
            // 
            M1b1.Image = Properties.Resources.Boru;
            M1b1.Location = new Point(71, 25);
            M1b1.Name = "M1b1";
            M1b1.Size = new Size(111, 10);
            M1b1.SizeMode = PictureBoxSizeMode.StretchImage;
            M1b1.TabIndex = 0;
            M1b1.TabStop = false;
            // 
            // yukleme
            // 
            yukleme.Image = Properties.Resources.arkaplan;
            yukleme.Location = new Point(672, 345);
            yukleme.Name = "yukleme";
            yukleme.Size = new Size(49, 30);
            yukleme.SizeMode = PictureBoxSizeMode.StretchImage;
            yukleme.TabIndex = 0;
            yukleme.TabStop = false;
            yukleme.Click += Durdur;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(610, 246);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Karıştırılıyor...";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(314, 163);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 3;
            label2.Text = "kabin 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.LightSteelBlue;
            label3.Location = new Point(208, 163);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 3;
            label3.Text = "kabin 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.LightSteelBlue;
            label4.Location = new Point(102, 163);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 3;
            label4.Text = "kabin 1";
            // 
            // k3deger
            // 
            k3deger.AutoSize = true;
            k3deger.BackColor = Color.Transparent;
            k3deger.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            k3deger.ForeColor = Color.LightSteelBlue;
            k3deger.Location = new Point(314, 187);
            k3deger.Name = "k3deger";
            k3deger.Size = new Size(0, 25);
            k3deger.TabIndex = 3;
            // 
            // k2deger
            // 
            k2deger.AutoSize = true;
            k2deger.BackColor = Color.Transparent;
            k2deger.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            k2deger.ForeColor = Color.LightSteelBlue;
            k2deger.Location = new Point(208, 187);
            k2deger.Name = "k2deger";
            k2deger.Size = new Size(0, 25);
            k2deger.TabIndex = 3;
            // 
            // k1deger
            // 
            k1deger.AutoSize = true;
            k1deger.BackColor = Color.Transparent;
            k1deger.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            k1deger.ForeColor = Color.LightSteelBlue;
            k1deger.Location = new Point(102, 187);
            k1deger.Name = "k1deger";
            k1deger.Size = new Size(0, 25);
            k1deger.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 398);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 398);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 448);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.LightSteelBlue;
            label8.Location = new Point(102, 425);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 3;
            label8.Text = "kabin 3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.LightSteelBlue;
            label9.Location = new Point(208, 375);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 3;
            label9.Text = "kabin 2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.LightSteelBlue;
            label10.Location = new Point(102, 375);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 3;
            label10.Text = "kabin 1 ";
            // 
            // button1
            // 
            button1.Location = new Point(314, 448);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.LightSteelBlue;
            label5.Location = new Point(208, 425);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 3;
            label5.Text = "Adet";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 448);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(842, 501);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(k1deger);
            Controls.Add(label9);
            Controls.Add(k2deger);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(k3deger);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kamyon);
            Controls.Add(M1b1);
            Controls.Add(M1b5);
            Controls.Add(M2b1);
            Controls.Add(M2b5);
            Controls.Add(M1b4);
            Controls.Add(M3b1);
            Controls.Add(M2b4);
            Controls.Add(M1b3);
            Controls.Add(M3b5);
            Controls.Add(M2b3);
            Controls.Add(M1b2);
            Controls.Add(M3b4);
            Controls.Add(M2b2);
            Controls.Add(M3b3);
            Controls.Add(M3b2);
            Controls.Add(mikserKapak);
            Controls.Add(kabin1);
            Controls.Add(baslat);
            Controls.Add(Motor3);
            Controls.Add(kabin2);
            Controls.Add(yukleme);
            Controls.Add(durdur);
            Controls.Add(Motor2);
            Controls.Add(kabin3);
            Controls.Add(Motor1);
            Controls.Add(mikserDurum);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Motor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)M3b1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Motor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Motor3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kamyon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mikserDurum).EndInit();
            ((System.ComponentModel.ISupportInitialize)mikserKapak).EndInit();
            ((System.ComponentModel.ISupportInitialize)kabin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kabin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kabin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)durdur).EndInit();
            ((System.ComponentModel.ISupportInitialize)baslat).EndInit();
            ((System.ComponentModel.ISupportInitialize)M3b2).EndInit();
            ((System.ComponentModel.ISupportInitialize)M3b3).EndInit();
            ((System.ComponentModel.ISupportInitialize)M3b4).EndInit();
            ((System.ComponentModel.ISupportInitialize)M3b5).EndInit();
            ((System.ComponentModel.ISupportInitialize)M2b2).EndInit();
            ((System.ComponentModel.ISupportInitialize)M2b3).EndInit();
            ((System.ComponentModel.ISupportInitialize)M2b4).EndInit();
            ((System.ComponentModel.ISupportInitialize)M2b5).EndInit();
            ((System.ComponentModel.ISupportInitialize)M2b1).EndInit();
            ((System.ComponentModel.ISupportInitialize)M1b2).EndInit();
            ((System.ComponentModel.ISupportInitialize)M1b3).EndInit();
            ((System.ComponentModel.ISupportInitialize)M1b4).EndInit();
            ((System.ComponentModel.ISupportInitialize)M1b5).EndInit();
            ((System.ComponentModel.ISupportInitialize)M1b1).EndInit();
            ((System.ComponentModel.ISupportInitialize)yukleme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox Motor1; 
        private PictureBox Motor2;
        private PictureBox Motor3;
        private PictureBox kamyon;
        private PictureBox mikserDurum;
        private PictureBox mikserKapak;
        private PictureBox kabin3;
        private PictureBox kabin2;
        private PictureBox kabin1;
        private PictureBox M3b1;
        private PictureBox durdur;
        private PictureBox baslat;
        private PictureBox M3b2;
        private PictureBox M3b3;
        private PictureBox M3b4;
        private PictureBox M3b5;
        private PictureBox M2b2;
        private PictureBox M2b3;
        private PictureBox M2b4;
        private PictureBox M2b5;
        private PictureBox M2b1;
        private PictureBox M1b2;
        private PictureBox M1b3;
        private PictureBox M1b4;
        private PictureBox M1b5;
        private PictureBox M1b1;
        private PictureBox yukleme;
        private Label label1;
        private System.Windows.Forms.Timer timer2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label k3deger;
        private Label k2deger;
        private Label k1deger;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
    }
}
