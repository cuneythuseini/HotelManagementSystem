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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");
        List<string> rooms = new List<string>();
        int noOfCustomer = 0;


        public void clearAllAreas()
        {
            tbName.Clear();
            tbLastName.Clear();
            cbGender.Text = "";
            mtPhoneNumber.Clear();
            tbIDNumber.Clear();
            tbNumberOfRooms.Clear();
            tbEmailAdress.Clear();
            tbPrice.Clear();
            dtpEntryDate.Text = "";
            dtpReleaseDay.Text = "";
        }

        public bool isFill()
        {
            if (tbName.Text.Trim().Length == 0 || tbLastName.Text.Trim().Length == 0 || cbGender.Text.Trim().Length == 0
                || mtPhoneNumber.Text.Trim().Length == 0 || tbIDNumber.Text.Trim().Length == 0 || tbNumberOfRooms.Text.Trim().Length == 0 ||
                tbEmailAdress.Text.Trim().Length == 0 || tbPrice.Text.Trim().Length == 0)
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
            oleDbCommand.CommandText = "select * from Informations";

            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = oleDbDataReader["NoCustomer"].ToString();
                listViewItem.SubItems.Add(oleDbDataReader["Name"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["LastName"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["Gender"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["PhoneNumber"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["IDNumber"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["NumberOfRooms"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["EMail"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["Price"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["EntryDate"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["ReleaseDate"].ToString());

                listView1.Items.Add(listViewItem);
            }
            oleDbConnection.Close();
        }

        private void btnShowInfos_Click(object sender, EventArgs e)
        {
            showInfos();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            noOfCustomer = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            tbName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mtPhoneNumber.Text = listView1.SelectedItems[0].SubItems[4].Text;
            tbIDNumber.Text = listView1.SelectedItems[0].SubItems[5].Text;
            tbNumberOfRooms.Text = listView1.SelectedItems[0].SubItems[6].Text;
            tbEmailAdress.Text = listView1.SelectedItems[0].SubItems[7].Text;
            tbPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpEntryDate.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpReleaseDay.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();

            if (isFill())
            {
                OleDbCommand oleDbCommand = new OleDbCommand("delete from Informations where NoCustomer=(" + noOfCustomer + ")", oleDbConnection);

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            if (isFill())
            {
                

                //OleDbCommand oleDbCommand = new OleDbCommand("UPDATE Informations SET Name='" + tbName.Text + "' where NoCustomer= '" + noOfCustomer + "'", oleDbConnection);

                OleDbCommand oleDbCommand = new OleDbCommand("UPDATE Informations SET Name='" + tbName.Text + "', LastName='" + tbLastName.Text + "',Gender='" + cbGender.Text + "',PhoneNumber='" + mtPhoneNumber.Text + "',IDNumber='" + tbIDNumber.Text + "',NumberOfRooms='" + tbNumberOfRooms.Text + "',EMail='" + tbEmailAdress.Text + "',Price='" + tbPrice.Text + "',EntryDate='" + dtpEntryDate.Value.ToString() + "',ReleaseDate='" + dtpReleaseDay.Value.ToString() + "' where NoCustomer= @noOfCustomer", oleDbConnection);
                oleDbCommand.Parameters.Add("NoCustomer", OleDbType.Integer).Value = noOfCustomer;
                oleDbCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Селектриајте Муштерија за да удредувате инофрмациите", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            oleDbConnection.Close();
            showInfos();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            oleDbConnection.Open();

            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = "select * from Informations where Name like '%" + tbFind.Text + "%'";

            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = oleDbDataReader["NoCustomer"].ToString();
                listViewItem.SubItems.Add(oleDbDataReader["Name"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["LastName"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["Gender"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["PhoneNumber"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["IDNumber"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["NumberOfRooms"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["EMail"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["Price"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["EntryDate"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["ReleaseDate"].ToString());

                listView1.Items.Add(listViewItem);
            }
            oleDbConnection.Close();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbFind_MouseHover(object sender, EventArgs e)
        {
            if (tbFind.Text == "Внесете име за пребарување")
            {
                tbFind.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllAreas();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            oleDbConnection.Open();

            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = "select NumberOfRooms from  Informations";

            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                rooms.Add(oleDbDataReader["NumberOfRooms"].ToString());
            }

            oleDbConnection.Close();
        }


    }
}
