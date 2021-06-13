using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel_Management_System
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");
        private void btnEnter_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            try
            {


                string accessConnection = "select * from AdminLogin where UserName=@user_name AND Password=@password";
                OleDbParameter parameter1 = new OleDbParameter("UserName", tbUserName.Text.Trim());
                OleDbParameter parameter2 = new OleDbParameter("Password", tbPassword.Text.Trim());

                OleDbCommand oleDbCommand = new OleDbCommand(accessConnection, oleDbConnection);
                oleDbCommand.Parameters.Add(parameter1);
                oleDbCommand.Parameters.Add(parameter2);

                DataTable dataTable = new DataTable();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
                oleDbDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    FrmHome frmHome = new FrmHome();
                    frmHome.Show();
                    this.Hide();
                    oleDbConnection.Close();
                    return;
                }

            }
            catch (Exception)
            {
                //MessageBox.Show("Погрешно корисничко име или лозинка", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Погрешно корисничко име или лозинка", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            oleDbConnection.Close();
                    
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text != "")
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text != "")
            {
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
            }
        }

       
    }
}
