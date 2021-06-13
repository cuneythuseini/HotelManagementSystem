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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");
        List<string> rooms = new List<string>();
        private void FrmRooms_Load(object sender, EventArgs e)
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
