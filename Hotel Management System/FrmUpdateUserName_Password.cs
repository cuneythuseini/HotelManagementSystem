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
    public partial class FrmUpdateUserName_Password : Form
    {
        public FrmUpdateUserName_Password()
        {
            InitializeComponent();
        }
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");
        private void btnEnter_Click(object sender, EventArgs e)
        {
            /*oleDbConnection.Open();

            //OleDbCommand oleDbCommand = new OleDbCommand("UPDATE Informations SET Name='" + tbName.Text + "' where NoCustomer= '" + noOfCustomer + "'", oleDbConnection);

            OleDbCommand oleDbCommand = new OleDbCommand("UPDATE AdminLogin SET UserName='" + tbUserName.Text + "', Password='" + tbPassword.Text + "'", oleDbConnection);
           // oleDbCommand.Parameters.Add("NoCustomer", OleDbType.Integer).Value = noOfCustomer;
            oleDbCommand.ExecuteNonQuery();

            oleDbConnection.Close();*/

            
        }
    }
}
