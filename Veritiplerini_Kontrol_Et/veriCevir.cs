using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritiplerini_Kontrol_Et
{
    public partial class veriCevir : Form
    {
        public veriCevir()
        {
            InitializeComponent();
            MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radio1_MouseClick(object sender, MouseEventArgs e)
        {
            sqlServerList.Enabled = true;
            sqlServerList.SelectedIndex = 0;
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            sqlServerList.Enabled = false;
            
        }

        private void radio2_MouseClick(object sender, MouseEventArgs e)
        {
            clrSqlServerList.Enabled = true;
            sqlServerList.SelectedIndex = 0;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            clrSqlServerList.Enabled = false;
        }

        private void radio3_MouseClick(object sender, MouseEventArgs e)
        {
            clrNetFList.Enabled = true;
            sqlServerList.SelectedIndex = 0;
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            clrNetFList.Enabled = false;

        }

        private void donusturBtn_Click(object sender, EventArgs e)
        {
            
            
            if (radio1.Checked == true)
            {
                

                sbyte stages = Convert.ToSByte(sqlServerList.SelectedIndex);
                if (stages == 0)
                {
                    clrSqlServerList.SelectedIndex = 0;
                    clrNetFList.SelectedIndex = 0;
                }
                for (sbyte x = 1; x <= stages; x++ )
                {
                    clrSqlServerList.SelectedIndex = x;
                    clrNetFList.SelectedIndex = x;

                }
            }
            
        }
    }
}
