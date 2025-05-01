using System.Windows.Forms;
using System.Drawing;
namespace Chronicle.Security.Operators
{
    partial class Search
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
            splitContainer1 = new SplitContainer();
            searchGroup = new GroupBox();
            searchBtn = new Button();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtPhoneNumber = new MaskedTextBox();
            label1 = new Label();
            txtOperatorID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDepartmentName = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            listView1 = new ListView();
            operatorIDCH = new ColumnHeader();
            operatorNameCH = new ColumnHeader();
            depatmentCH = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            searchGroup.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(searchGroup);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Size = new Size(694, 425);
            splitContainer1.SplitterDistance = 364;
            splitContainer1.TabIndex = 0;
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(txtEmail);
            searchGroup.Controls.Add(label6);
            searchGroup.Controls.Add(label5);
            searchGroup.Controls.Add(txtPhoneNumber);
            searchGroup.Controls.Add(label1);
            searchGroup.Controls.Add(txtOperatorID);
            searchGroup.Controls.Add(label4);
            searchGroup.Controls.Add(label3);
            searchGroup.Controls.Add(label2);
            searchGroup.Controls.Add(txtDepartmentName);
            searchGroup.Controls.Add(txtLastName);
            searchGroup.Controls.Add(txtFirstName);
            searchGroup.Dock = DockStyle.Fill;
            searchGroup.Location = new Point(0, 0);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(364, 425);
            searchGroup.TabIndex = 21;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search";
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchBtn.Location = new Point(283, 396);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 32;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 31;
            txtEmail.KeyDown += txtOperatorID_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 233);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 30;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 199);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 29;
            label5.Text = "Phone";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(94, 196);
            txtPhoneNumber.Mask = "999.999.9999";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(179, 23);
            txtPhoneNumber.TabIndex = 28;
            txtPhoneNumber.KeyDown += txtOperatorID_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 27;
            label1.Text = "Operator ID";
            // 
            // txtOperatorID
            // 
            txtOperatorID.Location = new Point(94, 34);
            txtOperatorID.Name = "txtOperatorID";
            txtOperatorID.Size = new Size(179, 23);
            txtOperatorID.TabIndex = 26;
            txtOperatorID.KeyDown += txtOperatorID_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 133);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 25;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 95);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 23;
            label2.Text = "First Name";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.FormattingEnabled = true;
            txtDepartmentName.Location = new Point(94, 130);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(179, 23);
            txtDepartmentName.TabIndex = 22;
            txtDepartmentName.KeyDown += txtOperatorID_KeyDown;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(94, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 23);
            txtLastName.TabIndex = 21;
            txtLastName.KeyDown += txtOperatorID_KeyDown;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(94, 63);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(179, 23);
            txtFirstName.TabIndex = 20;
            txtFirstName.KeyDown += txtOperatorID_KeyDown;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { operatorIDCH, operatorNameCH, depatmentCH });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(326, 425);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // operatorIDCH
            // 
            operatorIDCH.Text = "Operator ID";
            operatorIDCH.Width = 100;
            // 
            // operatorNameCH
            // 
            operatorNameCH.Text = "Name";
            operatorNameCH.Width = 120;
            // 
            // depatmentCH
            // 
            depatmentCH.Text = "Department";
            depatmentCH.Width = 100;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 425);
            Controls.Add(splitContainer1);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox searchGroup;
        private Button searchBtn;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private MaskedTextBox txtPhoneNumber;
        private Label label1;
        private TextBox txtOperatorID;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox txtDepartmentName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ListView listView1;
        private ColumnHeader operatorIDCH;
        private ColumnHeader operatorNameCH;
        private ColumnHeader depatmentCH;
    }
}