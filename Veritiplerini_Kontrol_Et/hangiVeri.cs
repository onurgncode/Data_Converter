using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Veritiplerini_Kontrol_Et
{
    public partial class hangiVeri : Form
    {
        public void banaveriver(string veri)
        {



            /*
            if (veri == "1")
                if (harfTik.Checked == true)
                    textBox1.Text = "Veri tipi: Char";
                else if (eksiSayiTik.Checked == true && radioVirgul.Checked == false)
                    textBox1.Text = "Veri tipi: sByte";
                else if (radioVirgul.Checked == true)
                    textBox1.Text = "Veri tipi: float";
                else
                    textBox1.Text = "Veri tipi: Byte,sByte";
            else if (veri == "1-100")
                if (harfTik.Checked == true)
                    textBox1.Text = "Veri tipi: String";
                else if (radioVirgul.Checked == true)
                    textBox1.Text = "Veri tipi: float";
                else if (sayiTik.Checked == true)
                    textBox1.Text = "Veri tipi: Byte";
                else if (zamanTik.Checked == true)
                    textBox1.Text = "Veri tipi: DateTime";
            else if (veri = "100")
                    if ()
            if (radioİki.Checked == true)
                    textBox1.Text = "Veri tipi: bool";
            */
        }
        public hangiVeri()
        {
            InitializeComponent();
            MaximizeBox = false;
            
        }

        private void hangiVeri_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        // Veri Getirme Butonu 
        private void button1_Click(object sender, EventArgs e)
        {
            sbyte zaman = 100;
            for (sbyte i = 0; i <= zaman; i++)
                progressBar1.Value = i;
            banaveriver(sayiAl.Text);
        }
        // Tiklenen Yerlerin kontrolü
        private void zamanTik_MouseClick(object sender, MouseEventArgs e)
        {
            switch (zamanTik.CheckState)
            {
                case CheckState.Checked:
                    sayiAl.Enabled = false;
                    sayiAl.Text = "Seçiniz";
                    sayiTik.Checked = true;
                    harfTik.Enabled = false;
                    harfTik.Checked = false;
                    harfTik.Enabled = false;
                    radioVirgul.Enabled = false;
                    radioVirgul.Checked = false;
                    radioİki.Checked = false;
                    radioİki.Enabled = false;
                    eksiSayiTik.Enabled = false;
                    eksiSayiTik.Checked = false;
                    break;
                case CheckState.Unchecked:
                    sayiAl.Enabled = true;
                    sayiTik.Checked = false;
                    harfTik.Enabled = true;
                    harfTik.Checked = false;
                    harfTik.Enabled = true;
                    radioVirgul.Enabled = true;
                    radioVirgul.Checked = false;
                    radioİki.Checked = false;
                    radioİki.Enabled = true;
                    eksiSayiTik.Enabled = true;
                    eksiSayiTik.Checked = false;
                    break;
            }


        }

        private void harfTik_MouseClick(object sender, MouseEventArgs e)
        {
            switch (harfTik.CheckState)
            {
                case CheckState.Checked:
                    zamanTik.Checked = false;
                    zamanTik.Enabled = false;
                    sayiTik.Checked = false;
                    sayiTik.Enabled = false;
                    radioVirgul.Enabled = false;
                    radioVirgul.Checked = false;
                    radioİki.Checked = false;
                    radioİki.Enabled = false;
                    eksiSayiTik.Enabled = false;
                    eksiSayiTik.Checked = false;
                    break;
                case CheckState.Unchecked:
                    zamanTik.Checked = false;
                    zamanTik.Enabled = true;
                    sayiTik.Checked = false;
                    sayiTik.Enabled = true;
                    radioVirgul.Enabled = true;
                    radioVirgul.Checked = false;
                    radioİki.Checked = false;
                    radioİki.Enabled = true;
                    eksiSayiTik.Enabled = true;
                    eksiSayiTik.Checked = false;
                    break;
            }
        }

        private void sayiTik_MouseClick(object sender, MouseEventArgs e)
        {
            switch (sayiTik.CheckState)
            {
                case CheckState.Checked:
                    harfTik.Checked = false;
                    harfTik.Enabled = false;
                    break;
                case CheckState.Unchecked:
                    harfTik.Checked = false;
                    harfTik.Enabled = true;
                    break;
            }
        }

        private void radioİki_MouseClick(object sender, MouseEventArgs e)
        {
            sayiAl.Enabled = false;
            sayiAl.Text = "Seçiniz";
            zamanTik.Checked = false;
            zamanTik.Enabled = false;
            sayiTik.Checked = true;
            sayiTik.Enabled = false;
            eksiSayiTik.Enabled = false;
            eksiSayiTik.Checked = false;
            harfTik.Checked = false;
            harfTik.Enabled = false;
        }

        private void radioİki_CheckedChanged(object sender, EventArgs e)
        {
            sayiAl.Enabled = true;
            zamanTik.Checked = false;
            zamanTik.Enabled = true;
            sayiTik.Checked = true;
            sayiTik.Enabled = true;
            eksiSayiTik.Enabled = true;
            eksiSayiTik.Checked = false;
            harfTik.Checked = false;
            harfTik.Enabled = true;
        }

        private void radioVirgul_MouseClick(object sender, MouseEventArgs e)
        {
            zamanTik.Checked = false;
            zamanTik.Enabled = false;
            sayiTik.Checked = true;
            sayiTik.Enabled = false;
            harfTik.Checked = false;
            harfTik.Enabled = false;
        }

        private void eksiSayiTik_MouseClick(object sender, MouseEventArgs e)
        {
            switch (eksiSayiTik.CheckState)
            {
                case CheckState.Checked:
                    harfTik.Checked = false;
                    harfTik.Enabled = false;
                    zamanTik.Checked = false;
                    zamanTik.Enabled = false;
                    sayiTik.Checked = true;
                    sayiTik.Enabled = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            harfTik.Checked = false;
            harfTik.Enabled = true;
            zamanTik.Checked = false;
            zamanTik.Enabled = true;
            sayiTik.Checked = false;
            sayiTik.Enabled = true;
            radioVirgul.Enabled = true;
            radioVirgul.Checked = false;
            radioİki.Checked = false;
            radioİki.Enabled = true;
            eksiSayiTik.Enabled = true;
            eksiSayiTik.Checked = false;
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Yazılımcıların işini daha da kolaylaştırsın diye düşünmüş bir programdır", "İleti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}