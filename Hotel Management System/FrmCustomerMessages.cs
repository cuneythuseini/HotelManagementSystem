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
    public partial class FrmCustomerMessages : Form
    {
        public FrmCustomerMessages()
        {
            InitializeComponent();
        }
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");
        int id = 0;

        private void clearAllAreas()
        {
            tbNameLastName.Clear();
            rtbMessage.Clear();
        }

        public bool isFill()
        {
            if (tbNameLastName.Text.Trim().Length == 0 || rtbMessage.Text.Trim().Length == 0)
            {
                return false;
            }
            return true;
        }

        private void showInfos()
        {
            listView1.Items.Clear();
            oleDbConnection.Open();

            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = "select * from CustomerMessages";

            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = oleDbDataReader["ID"].ToString();
                listViewItem.SubItems.Add(oleDbDataReader["NameLastName"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["CustomerMessage"].ToString());
 
                listView1.Items.Add(listViewItem);
            }
            oleDbConnection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFill())
            {
                oleDbConnection.Open();

                OleDbCommand oleDbCommand = new OleDbCommand("insert into CustomerMessages (NameLastName,CustomerMessage) values ('" + tbNameLastName.Text + "','" + rtbMessage.Text + "')", oleDbConnection);

                if (MessageBox.Show("Дали сакате да зачувате инофрмациите", "Зачувај", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oleDbCommand.ExecuteNonQuery();
                    clearAllAreas();
                }
                oleDbConnection.Close();

                showInfos();
            }
            else
            {
                MessageBox.Show("Пополните сите информации, не можете да оставите празни полиња", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            oleDbConnection.Close();
        }

        private void FrmCustomerMessages_Load(object sender, EventArgs e)
        {
            showInfos();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllAreas();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            tbNameLastName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            rtbMessage.Text = listView1.SelectedItems[0].SubItems[2].Text;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            if (isFill())
            {


                OleDbCommand oleDbCommand = new OleDbCommand("delete from CustomerMessages where ID=(" + id + ")", oleDbConnection);

                if (MessageBox.Show("Дали сакате да избришете муштеријата", "Избриши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oleDbCommand.ExecuteNonQuery();
                    clearAllAreas();
                }
            }
            else
            {
                MessageBox.Show("Селектриајте Муштерија за да избришете инофрмациите", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            oleDbConnection.Close();

            showInfos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();

            OleDbCommand oleDbCommand = new OleDbCommand("UPDATE CustomerMessages SET NameLastName='" + tbNameLastName.Text + "', CustomerMessage='" + rtbMessage.Text + "' where ID= @id", oleDbConnection);
            oleDbCommand.Parameters.Add("id", OleDbType.Integer).Value = id;
            oleDbCommand.ExecuteNonQuery();
            

            oleDbConnection.Close();

            showInfos();
        }
    }
}
