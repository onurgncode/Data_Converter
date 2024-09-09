namespace Veritiplerini_Kontrol_Et
{
    partial class hangiVeri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hangiVeri));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veriÇevirmeAracıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zamanTik = new System.Windows.Forms.CheckBox();
            this.harfTik = new System.Windows.Forms.CheckBox();
            this.sayiTik = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioİki = new System.Windows.Forms.RadioButton();
            this.radioVirgul = new System.Windows.Forms.RadioButton();
            this.eksiSayiTik = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sayiAl = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriÇevirmeAracıToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(706, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veriÇevirmeAracıToolStripMenuItem
            // 
            this.veriÇevirmeAracıToolStripMenuItem.Enabled = false;
            this.veriÇevirmeAracıToolStripMenuItem.Name = "veriÇevirmeAracıToolStripMenuItem";
            this.veriÇevirmeAracıToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.veriÇevirmeAracıToolStripMenuItem.Text = "Veri Çevirme Aracı";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Enabled = false;
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(108, 19);
            this.hakkımızdaToolStripMenuItem.Text = "Hangi Veri Türü ?";
            // 
            // hakkımızdaToolStripMenuItem1
            // 
            this.hakkımızdaToolStripMenuItem1.Name = "hakkımızdaToolStripMenuItem1";
            this.hakkımızdaToolStripMenuItem1.Size = new System.Drawing.Size(81, 19);
            this.hakkımızdaToolStripMenuItem1.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem1.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangi Veri Türünü Kullanmalıyım ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Karakter Sayınızı Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Burdaki veriler SQL Server veri türüne Göre \r\nListelenir";
            // 
            // zamanTik
            // 
            this.zamanTik.AutoSize = true;
            this.zamanTik.Location = new System.Drawing.Point(15, 174);
            this.zamanTik.Name = "zamanTik";
            this.zamanTik.Size = new System.Drawing.Size(130, 22);
            this.zamanTik.TabIndex = 7;
            this.zamanTik.Text = "Zaman İçerikli";
            this.zamanTik.UseVisualStyleBackColor = true;
            this.zamanTik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zamanTik_MouseClick);
            // 
            // harfTik
            // 
            this.harfTik.AutoSize = true;
            this.harfTik.Location = new System.Drawing.Point(15, 203);
            this.harfTik.Name = "harfTik";
            this.harfTik.Size = new System.Drawing.Size(124, 22);
            this.harfTik.TabIndex = 8;
            this.harfTik.Text = "Harf Şeklinde";
            this.harfTik.UseVisualStyleBackColor = true;
            this.harfTik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.harfTik_MouseClick);
            // 
            // sayiTik
            // 
            this.sayiTik.AutoSize = true;
            this.sayiTik.Location = new System.Drawing.Point(15, 232);
            this.sayiTik.Name = "sayiTik";
            this.sayiTik.Size = new System.Drawing.Size(124, 22);
            this.sayiTik.TabIndex = 9;
            this.sayiTik.Text = "Sayı Şeklinde";
            this.sayiTik.UseVisualStyleBackColor = true;
            this.sayiTik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sayiTik_MouseClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Burada Gözükecek";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Veri Türünü Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioİki
            // 
            this.radioİki.AutoSize = true;
            this.radioİki.Location = new System.Drawing.Point(201, 174);
            this.radioİki.Name = "radioİki";
            this.radioİki.Size = new System.Drawing.Size(112, 22);
            this.radioİki.TabIndex = 13;
            this.radioİki.TabStop = true;
            this.radioİki.Text = "İkilik sistem";
            this.radioİki.UseVisualStyleBackColor = true;
            this.radioİki.CheckedChanged += new System.EventHandler(this.radioİki_CheckedChanged);
            this.radioİki.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioİki_MouseClick);
            // 
            // radioVirgul
            // 
            this.radioVirgul.AutoSize = true;
            this.radioVirgul.Location = new System.Drawing.Point(201, 203);
            this.radioVirgul.Name = "radioVirgul";
            this.radioVirgul.Size = new System.Drawing.Size(114, 22);
            this.radioVirgul.TabIndex = 14;
            this.radioVirgul.TabStop = true;
            this.radioVirgul.Text = "Virgüllü Sayı";
            this.radioVirgul.UseVisualStyleBackColor = true;
            this.radioVirgul.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioVirgul_MouseClick);
            // 
            // eksiSayiTik
            // 
            this.eksiSayiTik.AutoSize = true;
            this.eksiSayiTik.Location = new System.Drawing.Point(201, 232);
            this.eksiSayiTik.Name = "eksiSayiTik";
            this.eksiSayiTik.Size = new System.Drawing.Size(139, 22);
            this.eksiSayiTik.TabIndex = 15;
            this.eksiSayiTik.Text = "- Sayılar içersin";
            this.eksiSayiTik.UseVisualStyleBackColor = true;
            this.eksiSayiTik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eksiSayiTik_MouseClick);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(225, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sayiAl
            // 
            this.sayiAl.FormattingEnabled = true;
            this.sayiAl.Items.AddRange(new object[] {
            "1",
            "1-100",
            "100",
            "200",
            "30 000",
            "2 000 000 000",
            "4 000 000 000",
            "Daha Fazla",
            "29 basamaktan daha fazla"});
            this.sayiAl.Location = new System.Drawing.Point(15, 80);
            this.sayiAl.Name = "sayiAl";
            this.sayiAl.Size = new System.Drawing.Size(89, 26);
            this.sayiAl.TabIndex = 17;
            this.sayiAl.Text = "Seçiniz";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(377, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 294);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // hangiVeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(706, 420);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sayiAl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eksiSayiTik);
            this.Controls.Add(this.radioVirgul);
            this.Controls.Add(this.radioİki);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sayiTik);
            this.Controls.Add(this.harfTik);
            this.Controls.Add(this.zamanTik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hangiVeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hangi Veri Türü ?";
            this.Load += new System.EventHandler(this.hangiVeri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veriÇevirmeAracıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox zamanTik;
        private System.Windows.Forms.CheckBox harfTik;
        private System.Windows.Forms.CheckBox sayiTik;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioİki;
        private System.Windows.Forms.RadioButton radioVirgul;
        private System.Windows.Forms.CheckBox eksiSayiTik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox sayiAl;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}