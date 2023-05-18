namespace RokettenKacmaOyunu
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
            timer1 = new System.Windows.Forms.Timer(components);
            UzayMekiği = new PictureBox();
            Oyun_pnl = new Panel();
            bilgi_lbl = new Label();
            skor_lbl = new Label();
            sag_btn = new Button();
            sol_btn = new Button();
            basla_btn = new Button();
            OyunAdı_lbl = new Label();
            Roket = new PictureBox();
            Kaybetme_pnl = new Panel();
            enyüksekskor_lbl = new Label();
            suankıskor_lbl = new Label();
            label1 = new Label();
            tekraroyna_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)UzayMekiği).BeginInit();
            Oyun_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Roket).BeginInit();
            Kaybetme_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // UzayMekiği
            // 
            UzayMekiği.BackColor = Color.Transparent;
            UzayMekiği.BackgroundImage = Properties.Resources.uzaymekıgı;
            UzayMekiği.BackgroundImageLayout = ImageLayout.Center;
            UzayMekiği.Location = new Point(160, 337);
            UzayMekiği.Name = "UzayMekiği";
            UzayMekiği.Size = new Size(157, 103);
            UzayMekiği.TabIndex = 0;
            UzayMekiği.TabStop = false;
            UzayMekiği.Click += UzayMekiği_Click;
            // 
            // Oyun_pnl
            // 
            Oyun_pnl.BackColor = Color.Gainsboro;
            Oyun_pnl.Controls.Add(bilgi_lbl);
            Oyun_pnl.Controls.Add(skor_lbl);
            Oyun_pnl.Controls.Add(sag_btn);
            Oyun_pnl.Controls.Add(sol_btn);
            Oyun_pnl.Dock = DockStyle.Bottom;
            Oyun_pnl.Location = new Point(0, 461);
            Oyun_pnl.Name = "Oyun_pnl";
            Oyun_pnl.Size = new Size(484, 100);
            Oyun_pnl.TabIndex = 1;
            // 
            // bilgi_lbl
            // 
            bilgi_lbl.AutoSize = true;
            bilgi_lbl.BackColor = Color.Transparent;
            bilgi_lbl.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bilgi_lbl.ForeColor = Color.Black;
            bilgi_lbl.Location = new Point(3, 49);
            bilgi_lbl.Name = "bilgi_lbl";
            bilgi_lbl.Size = new Size(48, 23);
            bilgi_lbl.TabIndex = 2;
            bilgi_lbl.Text = "Bilgi !";
            bilgi_lbl.TextAlign = ContentAlignment.MiddleLeft;
            bilgi_lbl.MouseLeave += bilgi_lbl_MouseLeave;
            bilgi_lbl.MouseHover += bilgi_lbl_MouseHover;
            // 
            // skor_lbl
            // 
            skor_lbl.BackColor = Color.Transparent;
            skor_lbl.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            skor_lbl.ForeColor = Color.Black;
            skor_lbl.Location = new Point(3, 12);
            skor_lbl.Name = "skor_lbl";
            skor_lbl.Size = new Size(114, 28);
            skor_lbl.TabIndex = 2;
            skor_lbl.Text = "Skor : 0";
            skor_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sag_btn
            // 
            sag_btn.BackColor = Color.Gray;
            sag_btn.CausesValidation = false;
            sag_btn.Enabled = false;
            sag_btn.FlatStyle = FlatStyle.Flat;
            sag_btn.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            sag_btn.ImageAlign = ContentAlignment.TopCenter;
            sag_btn.Location = new Point(241, 12);
            sag_btn.Name = "sag_btn";
            sag_btn.Size = new Size(60, 60);
            sag_btn.TabIndex = 0;
            sag_btn.TabStop = false;
            sag_btn.Text = ">";
            sag_btn.UseVisualStyleBackColor = false;
            sag_btn.Click += sag_btn_Click;
            // 
            // sol_btn
            // 
            sol_btn.BackColor = Color.Gray;
            sol_btn.CausesValidation = false;
            sol_btn.Enabled = false;
            sol_btn.FlatStyle = FlatStyle.Flat;
            sol_btn.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            sol_btn.ImageAlign = ContentAlignment.TopCenter;
            sol_btn.Location = new Point(175, 12);
            sol_btn.Name = "sol_btn";
            sol_btn.Size = new Size(60, 60);
            sol_btn.TabIndex = 0;
            sol_btn.TabStop = false;
            sol_btn.Text = "<";
            sol_btn.UseVisualStyleBackColor = false;
            sol_btn.Click += sol_btn_Click;
            // 
            // basla_btn
            // 
            basla_btn.BackColor = Color.Lime;
            basla_btn.FlatStyle = FlatStyle.Flat;
            basla_btn.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            basla_btn.ForeColor = Color.Black;
            basla_btn.Location = new Point(160, 117);
            basla_btn.Name = "basla_btn";
            basla_btn.Size = new Size(157, 51);
            basla_btn.TabIndex = 0;
            basla_btn.Text = "Başla";
            basla_btn.UseVisualStyleBackColor = false;
            basla_btn.Click += basla_btn_Click;
            // 
            // OyunAdı_lbl
            // 
            OyunAdı_lbl.BackColor = Color.Transparent;
            OyunAdı_lbl.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            OyunAdı_lbl.ForeColor = Color.Aqua;
            OyunAdı_lbl.Location = new Point(0, 9);
            OyunAdı_lbl.Name = "OyunAdı_lbl";
            OyunAdı_lbl.Size = new Size(484, 75);
            OyunAdı_lbl.TabIndex = 2;
            OyunAdı_lbl.Text = "Roketten Kaçış Oyunu";
            OyunAdı_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // Roket
            // 
            Roket.BackColor = Color.Transparent;
            Roket.BackgroundImage = Properties.Resources.roket;
            Roket.BackgroundImageLayout = ImageLayout.Center;
            Roket.Location = new Point(211, 3);
            Roket.Name = "Roket";
            Roket.Size = new Size(46, 108);
            Roket.TabIndex = 3;
            Roket.TabStop = false;
            Roket.Visible = false;
            Roket.Click += Roket_Click;
            // 
            // Kaybetme_pnl
            // 
            Kaybetme_pnl.BackColor = Color.White;
            Kaybetme_pnl.Controls.Add(enyüksekskor_lbl);
            Kaybetme_pnl.Controls.Add(suankıskor_lbl);
            Kaybetme_pnl.Controls.Add(label1);
            Kaybetme_pnl.Controls.Add(tekraroyna_btn);
            Kaybetme_pnl.Location = new Point(29, 117);
            Kaybetme_pnl.Name = "Kaybetme_pnl";
            Kaybetme_pnl.Size = new Size(420, 319);
            Kaybetme_pnl.TabIndex = 4;
            Kaybetme_pnl.Visible = false;
            // 
            // enyüksekskor_lbl
            // 
            enyüksekskor_lbl.BackColor = Color.Transparent;
            enyüksekskor_lbl.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            enyüksekskor_lbl.ForeColor = Color.Gold;
            enyüksekskor_lbl.Location = new Point(3, 91);
            enyüksekskor_lbl.Name = "enyüksekskor_lbl";
            enyüksekskor_lbl.Size = new Size(417, 42);
            enyüksekskor_lbl.TabIndex = 2;
            enyüksekskor_lbl.Text = "En Yüksek Skor : 000";
            enyüksekskor_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // suankıskor_lbl
            // 
            suankıskor_lbl.BackColor = Color.Transparent;
            suankıskor_lbl.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            suankıskor_lbl.ForeColor = Color.DeepPink;
            suankıskor_lbl.Location = new Point(3, 159);
            suankıskor_lbl.Name = "suankıskor_lbl";
            suankıskor_lbl.Size = new Size(417, 42);
            suankıskor_lbl.TabIndex = 2;
            suankıskor_lbl.Text = "Şuanki Skorun : 000";
            suankıskor_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-9, 0);
            label1.Name = "label1";
            label1.Size = new Size(429, 69);
            label1.TabIndex = 2;
            label1.Text = "Kaybettin";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tekraroyna_btn
            // 
            tekraroyna_btn.BackColor = Color.DeepSkyBlue;
            tekraroyna_btn.FlatStyle = FlatStyle.Flat;
            tekraroyna_btn.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tekraroyna_btn.ForeColor = Color.Black;
            tekraroyna_btn.Location = new Point(85, 265);
            tekraroyna_btn.Name = "tekraroyna_btn";
            tekraroyna_btn.Size = new Size(238, 51);
            tekraroyna_btn.TabIndex = 0;
            tekraroyna_btn.Text = "Tekrar Oyna !";
            tekraroyna_btn.UseVisualStyleBackColor = false;
            tekraroyna_btn.Click += tekraroyna_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            ClientSize = new Size(484, 561);
            Controls.Add(Kaybetme_pnl);
            Controls.Add(Roket);
            Controls.Add(OyunAdı_lbl);
            Controls.Add(Oyun_pnl);
            Controls.Add(UzayMekiği);
            Controls.Add(basla_btn);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roketten Kaçış Oyunu";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)UzayMekiği).EndInit();
            Oyun_pnl.ResumeLayout(false);
            Oyun_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Roket).EndInit();
            Kaybetme_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox UzayMekiği;
        private Panel Oyun_pnl;
        private Label skor_lbl;
        private Button sag_btn;
        private Button sol_btn;
        private Button basla_btn;
        private Label OyunAdı_lbl;
        private PictureBox Roket;
        private Panel Kaybetme_pnl;
        private Label label1;
        private Label suankıskor_lbl;
        private Button tekraroyna_btn;
        private Label enyüksekskor_lbl;
        private Label bilgi_lbl;
    }
}