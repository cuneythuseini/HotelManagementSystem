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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin frmAdminLogin = new FrmAdminLogin();
            frmAdminLogin.Show();
            this.Hide();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
            frmNewCustomer.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            FrmRooms frmRooms = new FrmRooms();
            frmRooms.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проектот е направен за предметот Визуелно Програмирање 2020/2021\n\n\t\t\t\tЏунејт Хусеини", "ФИНКИ, СКОПЈЕ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frmRadio = new FrmRadio();
            frmRadio.Show();
        }

        private void btnNewspaper_Click(object sender, EventArgs e)
        {
            FrmNewsPaper frmNewsPaper = new FrmNewsPaper();
            frmNewsPaper.Show();
        }

        private void btnCustomerMessages_Click(object sender, EventArgs e)
        {
            FrmCustomerMessages frmCustomerMessages = new FrmCustomerMessages();
            frmCustomerMessages.Show();
        }
    }
}
