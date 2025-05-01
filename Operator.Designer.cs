using System.Windows.Forms;
using System.Drawing;
namespace Chronicle.Security.Operators
{
    partial class Operator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            txtOperatorID = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBox2 = new ComboBox();
            label9 = new Label();
            button2 = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            tabPage3 = new TabPage();
            txtEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPhoneNumber = new MaskedTextBox();
            tabPage2 = new TabPage();
            permissionsGrid = new DataGridView();
            className = new DataGridViewComboBoxColumn();
            isPrimary = new DataGridViewCheckBoxColumn();
            viewAudit = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)permissionsGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtOperatorID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 59);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(0, 36);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Add Class";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(245, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += doSave;
            // 
            // txtOperatorID
            // 
            txtOperatorID.Location = new Point(91, 12);
            txtOperatorID.Name = "txtOperatorID";
            txtOperatorID.ReadOnly = true;
            txtOperatorID.Size = new Size(229, 23);
            txtOperatorID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Operator ID";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(332, 307);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Menu;
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(324, 279);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(78, 248);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 23);
            comboBox2.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 244);
            label9.Name = "label9";
            label9.Size = new Size(43, 30);
            label9.TabIndex = 14;
            label9.Text = "Access\r\nProfile";
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(220, 204);
            button2.Name = "button2";
            button2.Size = new Size(37, 23);
            button2.TabIndex = 13;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 208);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 12;
            label8.Text = "Manager";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 205);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 10;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(78, 180);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Is Manager?";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(78, 108);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 82);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(78, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 23);
            textBox4.TabIndex = 6;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 154);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 52);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 23);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Menu;
            tabPage3.Controls.Add(txtEmail);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtPhoneNumber);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(324, 279);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Contact";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 52);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 34;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 18);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 33;
            label7.Text = "Phone";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(62, 15);
            txtPhoneNumber.Mask = "999.999.9999";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(179, 23);
            txtPhoneNumber.TabIndex = 32;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Menu;
            tabPage2.Controls.Add(permissionsGrid);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(324, 279);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Permissions";
            // 
            // permissionsGrid
            // 
            permissionsGrid.AllowUserToAddRows = false;
            permissionsGrid.AllowUserToOrderColumns = true;
            permissionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            permissionsGrid.Columns.AddRange(new DataGridViewColumn[] { className, isPrimary, viewAudit });
            permissionsGrid.Dock = DockStyle.Fill;
            permissionsGrid.Location = new Point(0, 0);
            permissionsGrid.Name = "permissionsGrid";
            permissionsGrid.Size = new Size(324, 279);
            permissionsGrid.TabIndex = 0;
            permissionsGrid.CellContentClick += permissionsGrid_CellContentClick;
            permissionsGrid.UserDeletingRow += permissionsGrid_UserDeletingRow;
            // 
            // className
            // 
            className.HeaderText = "Name";
            className.Name = "className";
            className.Resizable = DataGridViewTriState.True;
            className.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // isPrimary
            // 
            isPrimary.HeaderText = "Primary";
            isPrimary.Name = "isPrimary";
            isPrimary.Resizable = DataGridViewTriState.True;
            // 
            // viewAudit
            // 
            viewAudit.HeaderText = "Audit";
            viewAudit.Name = "viewAudit";
            viewAudit.Text = "View";
            // 
            // Operator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 366);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Operator";
            Text = "Operator";
            Load += Operator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)permissionsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtOperatorID;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TabPage tabPage2;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TabPage tabPage3;
        private TextBox txtEmail;
        private Label label6;
        private Label label7;
        private MaskedTextBox txtPhoneNumber;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label8;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label9;
        private DataGridView permissionsGrid;
        private Button button3;
        private DataGridViewComboBoxColumn className;
        private DataGridViewCheckBoxColumn isPrimary;
        private DataGridViewButtonColumn viewAudit;
    }
}