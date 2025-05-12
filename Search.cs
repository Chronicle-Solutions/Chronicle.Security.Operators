using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using FontAwesome.Sharp;
using Chronicle.Utils;

namespace Chronicle.Security.Operators
{
    public partial class Search : Form
    {
        public string OperatorID { get => _operatorID ?? ""; }
        private string? _operatorID;

        public Search()
        {
            InitializeComponent();


        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM OPERATORS A ,DEPARTMENTS B WHERE A.departmentID = B.departmentID";
                if (!string.IsNullOrEmpty(txtOperatorID.Text))
                {
                    cmd.CommandText += " AND operatorID LIKE @oprID";
                    cmd.Parameters.AddWithValue("@oprID", txtOperatorID.Text + "%");
                }

                if (!string.IsNullOrEmpty(txtFirstName.Text))
                {
                    cmd.CommandText += " AND firstName SOUNDS LIKE @firstName";
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text + "");
                }

                if (!string.IsNullOrEmpty(txtLastName.Text))
                {
                    cmd.CommandText += " AND lastName SOUNDS LIKE @lastName";
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text + "");
                }

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    cmd.CommandText += " AND emailID LIKE @email";
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text + "%");
                }

                if (!string.IsNullOrEmpty(txtPhoneNumber.Text) && txtPhoneNumber.MaskFull)
                {
                    cmd.CommandText += " AND phoneNumber LIKE @phone";
                    cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text + "%");
                }

                if (!string.IsNullOrEmpty(txtDepartmentName.SelectedText))
                {
                    cmd.CommandText += " AND departmentName LIKE @depName";
                    cmd.Parameters.AddWithValue("@depName", txtDepartmentName.SelectedText + "%");
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = reader.GetString("operatorID");
                    itm.SubItems.Add(reader.GetString("lastName") + ", " + reader.GetString("firstName"));
                    itm.SubItems.Add(reader.GetString("departmentName"));
                    listView1.Items.Add(itm);
                }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DEPARTMENTS";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtDepartmentName.Items.Add(reader.GetString("departmentName"));
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            _operatorID = listView1.SelectedItems[0].SubItems[0].Text;
            DialogResult = DialogResult.OK;

        }

        private void txtOperatorID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, new EventArgs());
            }
        }
    }
}
