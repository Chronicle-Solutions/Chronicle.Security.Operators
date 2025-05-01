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
using Isopoh.Cryptography.Argon2;

namespace Chronicle.Security.Operators
{
    public partial class Operator : Form
    {
        private bool updatePassword = false;
        List<DataGridViewRow> insertRows = new List<DataGridViewRow>();
        List<DataGridViewRow> deleteRows = new List<DataGridViewRow>();
        public string OperatorID
        {
            get => _OperatorID; set
            {
                _OperatorID = value;
                OperatorChanged.Invoke(_OperatorID, EventArgs.Empty);
            }
        }
        private string _OperatorID;

        public event EventHandler OperatorChanged;
        public Operator(bool isInit)
        {
            InitializeComponent();
            Text = "New Operator";
            txtOperatorID.ReadOnly = !isInit;
            button1.Text = isInit ? "Create" : "Update";
            OperatorChanged += new EventHandler(onOperatorChange);
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DEPARTMENTS";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("departmentName"));
                }
                reader.Close();

                cmd.CommandText = "SELECT * FROM ACCESS_PROFILES";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString("profileDescription"));
                }
            }

            button2.Image = IconChar.User.ToBitmap(16);
        }

        private void onOperatorChange(object? sender, EventArgs e)
        {
            textBox4.TextChanged -= textBox4_TextChanged;
            updatePassword = false;
            Text = _OperatorID;
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM OPERATORS A, DEPARTMENTS B, ACCESS_PROFILES C WHERE A.departmentID = B.departmentID AND A.accessProfileID = C.accessProfileID AND operatorID = @oprID";
                cmd.Parameters.AddWithValue("@oprID", sender as string);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read()) return;
                txtOperatorID.Text = sender as string;
                textBox2.Text = reader["firstName"] as string ?? "";
                textBox3.Text = reader["lastName"] as string ?? "";
                textBox4.Text = "xxxxxxxxxxxxxxxxxx";
                comboBox1.Text = reader["departmentName"] as string ?? "";
                txtPhoneNumber.Text = reader["phoneNumber"] as string ?? "";
                txtEmail.Text = reader["emailID"] as string ?? "";
                comboBox2.Text = reader["profileDescription"] as string ?? "";
                reader.Close();

                cmd.CommandText = "SELECT A.classDescr, B.isPrimary, B.addedBy, B.addedDt, B.updateBy, B.updateDt FROM OPERATOR_CLASS A, OPERATOR_CLASS_LINK B WHERE A.operatorClassID = B.operatorClassID AND B.operatorID = @oprID";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewComboBoxCell className = new DataGridViewComboBoxCell();
                    className.Items.AddRange(getClassNames());
                    className.Value = reader["classDescr"] as string ?? "";
                    row.Cells.Add(className);
                    className.ReadOnly = true;
                    className.Style.ForeColor = Color.Gray;


                    DataGridViewCheckBoxCell isPrimary = new DataGridViewCheckBoxCell();
                    isPrimary.Value = reader.GetBoolean("isPrimary");
                    row.Cells.Add(isPrimary);
                    isPrimary.Style.ForeColor = Color.Gray;
                    isPrimary.ReadOnly = true;

                    DataGridViewButtonCell btn = new DataGridViewButtonCell();
                    row.Cells.Add(btn);
                    permissionsGrid.Rows.Add(row);


                }

            }
            textBox4.TextChanged += textBox4_TextChanged;
        }

        private string[] getClassNames()
        {
            List<string> classNames = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM OPERATOR_CLASS";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    classNames.Add(reader["classDescr"] as string ?? "");
                }
            }
            return classNames.ToArray();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void doSave(object sender, EventArgs e)
        {
            // Update or Create.
            if (txtOperatorID.ReadOnly) updateOperator();
            else createOperator();
        }

        private void updateOperator()
        {
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE OPERATORS SET firstName=@fName, lastName=@lName, emailID=@eID, manager=(SELECT B.operatorID FROM OPERATORS B WHERE CONCAT(B.lastName, ', ', B.firstName) = @manager), phoneNumber = @pNum, accessProfileID=(SELECT accessProfileID FROM ACCESS_PROFILES WHERE profileDescription = @apid), departmentID=(SELECT departmentID from DEPARTMENTS where departmentName = @dept), updateBy=@oprID, updateDt=current_timestamp WHERE operatorID=@newOprID;";
                cmd.Parameters.AddWithValue("@newOprID", txtOperatorID.Text);
                cmd.Parameters.AddWithValue("@fName", textBox2.Text);
                cmd.Parameters.AddWithValue("@lName", textBox3.Text);
                cmd.Parameters.AddWithValue("@eID", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pNum", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@apid", comboBox2.Text);
                cmd.Parameters.AddWithValue("@dept", comboBox1.Text);
                cmd.Parameters.AddWithValue("@oprID", Globals.OperatorID);
                cmd.Parameters.AddWithValue("@manager", textBox1.Text);
                cmd.ExecuteNonQuery();
                // Check if password needs update:
                if (updatePassword)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE OPERATORS SET password=@pWord WHERE operatorID=@newOprID";
                    cmd.Parameters.AddWithValue("@newOprID", txtOperatorID.Text);
                    cmd.Parameters.AddWithValue("@pWord", Argon2.Hash(textBox4.Text));
                    cmd.ExecuteNonQuery();
                }


                txtOperatorID.ReadOnly = true;
                button1.Text = "Update";
                // Update Classes

                // Insert New Classes
                foreach (DataGridViewRow row in insertRows)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO OPERATOR_CLASS_LINK (operatorID, operatorClassID, isPrimary, addedBy, addedDt, updateBy, updateDt) VALUES (@newOprID, (SELECT operatorClassID FROM OPERATOR_CLASS WHERE classDescr = @oprClassName), @prim, @oprID, current_timestamp, @oprID, current_timestamp)";
                    cmd.Parameters.AddWithValue("@oprID", Globals.OperatorID);
                    cmd.Parameters.AddWithValue("@newOprID", txtOperatorID.Text);
                    cmd.Parameters.AddWithValue("@oprClassName", row.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@prim", row.Cells[1].Value as bool? ?? false);
                    cmd.ExecuteNonQuery();
                }

                // Delete Removed Classes
                foreach (DataGridViewRow row in deleteRows)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "DELETE FROM OPERATOR_CLASS_LINK WHERE operatorID=@newOprID AND operatorClassID = (SELECT operatorClassID FROM OPERATOR_CLASS WHERE classDescr = @oprClassName)";
                    cmd.Parameters.AddWithValue("@newOprID", txtOperatorID.Text);
                    cmd.Parameters.AddWithValue("@oprClassName", row.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                }


                insertRows.Clear();
                deleteRows.Clear();

            }
        }

        private void createOperator()
        {
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO OPERATORS (operatorID, firstName, lastName, emailID, manager, phoneNumber, password, accessProfileID, departmentID, addedBy, addedDt, updateBy, updateDt) VALUES" +
                    "(@newOprID, @fName, @lName, @eID, (SELECT B.operatorID FROM OPERATORS B WHERE CONCAT(B.lastName, ', ', B.firstName) = @manager), @pNum, @pass, (SELECT accessProfileID FROM ACCESS_PROFILES WHERE profileDescription = @apid) , (SELECT departmentID from DEPARTMENTS where departmentName = @dept), @oprID, current_timestamp, @oprID, current_timestamp)";
                cmd.Parameters.AddWithValue("@newOprID", txtOperatorID.Text);
                cmd.Parameters.AddWithValue("@fName", textBox2.Text);
                cmd.Parameters.AddWithValue("@lName", textBox3.Text);
                cmd.Parameters.AddWithValue("@eID", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pNum", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@pass", Argon2.Hash(textBox4.Text));
                cmd.Parameters.AddWithValue("@apid", comboBox2.Text);
                cmd.Parameters.AddWithValue("@dept", comboBox1.Text);
                cmd.Parameters.AddWithValue("@oprID", Globals.OperatorID);
                cmd.Parameters.AddWithValue("@manager", textBox1.Text);
                cmd.ExecuteNonQuery();
                txtOperatorID.ReadOnly = true;
                button1.Text = "Update";
                // Insert Classes
                foreach (DataGridViewRow permRow in permissionsGrid.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO OPERATOR_CLASS_LINK (operatorID, operatorClassID, isPrimary, addedBy, addedDt, updateBy, updateDt) VALUES (@newOprID, (SELECT operatorClassID FROM OPERATOR_CLASS WHERE classDescr = @oprClassName), @prim, @oprID, current_timestamp, @oprID, current_timestamp)";
                    cmd.Parameters.AddWithValue("@oprID", Globals.OperatorID);
                    cmd.Parameters.AddWithValue("@newOprID", txtOperatorID.Text);
                    cmd.Parameters.AddWithValue("@oprClassName", permRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@prim", permRow.Cells[1].Value as bool? ?? false);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (updatePassword) return;

            DialogResult res = MessageBox.Show("Caution. You are about to update this operator's password.\r\nOnly do this if you are sure that you want to change this operator's password.\r\nPress \"OK\" to continue or press \"Cancel\" to cancel this operation.", "Warning: Password Change Detected", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            updatePassword = res != DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            if (s.ShowDialog() != DialogResult.OK) return;
            using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT CONCAT(lastName, ', ', firstName) FROM OPERATORS WHERE operatorID = @oprID";
                cmd.Parameters.AddWithValue("@oprID", s.OperatorID);
                textBox1.Text = cmd.ExecuteScalar() as string ?? "";
            }

        }

        private void Operator_Load(object sender, EventArgs e)
        {

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Visible = tabControl1.SelectedIndex == 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
            comboCell.Items.AddRange(getClassNames());
            row.Cells.Add(comboCell);

            DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
            row.Cells.Add(checkCell);

            DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
            row.Cells.Add(buttonCell);

            permissionsGrid.Rows.Add(row);
            insertRows.Add(row);
        }

        private void permissionsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e is null) return;
            if (e.Row is null) return;

            deleteRows.Add(e.Row);
            insertRows.Remove(e.Row);
        }

        private void permissionsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // View Audit
            if(e.RowIndex == 2)
            {
                /*using (MySqlConnection conn = new MySqlConnection(Globals.ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM OPERATOR_CLASS_LINK WHERE operatorID = @oprID AND operatorClassID = (SELECT operatorClassID FROM OPERATOR_CLASS WHERE classDescr = @oprClassName)";

                    MessageBox.Show("", "Permission Audit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                throw new NotImplementedException();
                
            }
        }
    }
}
