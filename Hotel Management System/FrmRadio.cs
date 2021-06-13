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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        public void makeAllVisible()
        {
            label1.Visible = true;
            label2.Visible = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://www.kanal77.mk:8088/live.mp3";
            label2.Text = "Канал-1";
            makeAllVisible();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://176.9.117.123:9998/;stream.mp3";
            label2.Text = "Канал-2";
            makeAllVisible();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://eu4.fastcast4u.com/proxy/metradio/?mp=/stream";
            label2.Text = "Канал-3";
            makeAllVisible();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://eu9.fastcast4u.com:6908/;stream.mp3";
            label2.Text = "Канал-4";
            makeAllVisible();
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }
    }
}
