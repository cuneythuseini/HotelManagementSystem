using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FrmNewsPaper : Form
    {
        public FrmNewsPaper()
        {
            InitializeComponent();
        }

        private void новаМакедонијаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.novamakedonija.com.mk/");
        }

        private void канал5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://kanal5.com.mk/");
        }

        private void сителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://sitel.com.mk/");
        }

        private void спортскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://sportski.mk/");
        }

        private void спортКлубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://sportclub.mk/");
        }
    }
}
