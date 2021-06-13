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
    public partial class FrmNewCustomer : Form
    {
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\CustomerInfos.mdb

        public FrmNewCustomer()
        {
            InitializeComponent();
        }
 
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");
        List<string> rooms = new List<string>();

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
        private void room_101_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "101";
        }

        private void room_102_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "102";
        }

        private void room_103_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "103";
        }

        private void room_104_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "104";
        }

        private void room_105_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "105";
        }

        private void room_106_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "106";
        }

        private void room_107_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "107";
        }

        private void room_108_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "108";
        }

        private void room_109_Click(object sender, EventArgs e)
        {
            tbNumberOfRooms.Text = "109";
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Копчињата во црвена боја означуваат целосни соби", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зелените обоени копчиња означуваат празни соби", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            if (isFill())
            {
                OleDbCommand oleDbCommand = new OleDbCommand("insert into Informations (Name,LastName,Gender,PhoneNumber,IDNumber,NumberOfRooms,EMail,Price,EntryDate,ReleaseDate) values ('" + tbName.Text + "','" + tbLastName.Text + "','" + cbGender.Text + "','" + mtPhoneNumber.Text + "','" + tbIDNumber.Text + "','" + tbNumberOfRooms.Text + "','" + tbEmailAdress.Text + "','" + tbPrice.Text + "','" + dtpEntryDate.Value.ToString() + "','" + dtpReleaseDay.Value.ToString() + "')", oleDbConnection);

                if ((MessageBox.Show("Дали сакате да зачувате инофрмациите", "Зачувај", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    if (rooms.Contains("101"))
                    {
                        room_101.BackColor = Color.Red;
                        room_101.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "102")
                    {
                        room_102.BackColor = Color.Red;
                        room_102.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "103")
                    {
                        room_103.BackColor = Color.Red;
                        room_103.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "104")
                    {
                        room_104.BackColor = Color.Red;
                        room_104.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "105")
                    {
                        room_105.BackColor = Color.Red;
                        room_105.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "106")
                    {
                        room_106.BackColor = Color.Red;
                        room_106.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "107")
                    {
                        room_107.BackColor = Color.Red;
                        room_107.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "108")
                    {
                        room_108.BackColor = Color.Red;
                        room_108.Enabled = false;
                    }
                    if (tbNumberOfRooms.Text == "109")
                    {
                        room_109.BackColor = Color.Red;
                        room_109.Enabled = false;
                    }
                    oleDbCommand.ExecuteNonQuery();
                    clearAllAreas();
                }
            }
            else
            {
                MessageBox.Show("Пополните сите информации, не можете да оставите празни полиња", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            oleDbConnection.Close();
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
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
            if (rooms.Contains("101"))
            {
                room_101.BackColor = Color.Red;
                room_101.Enabled = false;
            }
            if (rooms.Contains("102"))
            {
                room_102.BackColor = Color.Red;
                room_102.Enabled = false;
            }
            if (rooms.Contains("103"))
            {
                room_103.BackColor = Color.Red;
                room_103.Enabled = false;
            }
            if (rooms.Contains("104"))
            {
                room_104.BackColor = Color.Red;
                room_104.Enabled = false;
            }
            if (rooms.Contains("105"))
            {
                room_105.BackColor = Color.Red;
                room_105.Enabled = false;
            }
            if (rooms.Contains("106"))
            {
                room_106.BackColor = Color.Red;
                room_106.Enabled = false;
            }
            if (rooms.Contains("107"))
            {
                room_107.BackColor = Color.Red;
                room_107.Enabled = false;
            }
            if (rooms.Contains("108"))
            {
                room_108.BackColor = Color.Red;
                room_108.Enabled = false;
            }
            if (rooms.Contains("109"))
            {
                room_109.BackColor = Color.Red;
                room_109.Enabled = false;
            }

            oleDbConnection.Close();
        }
    }
}
