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
            txtOperatorID = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtOperatorID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 59);
            panel1.TabIndex = 0;
            // 
            // txtOperatorID
            // 
            txtOperatorID.Location = new Point(97, 21);
            txtOperatorID.Name = "txtOperatorID";
            txtOperatorID.ReadOnly = true;
            txtOperatorID.Size = new Size(229, 23);
            txtOperatorID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
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
            tabControl1.Size = new Size(332, 250);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Menu;
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
            tabPage1.Size = new Size(324, 222);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
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
            label4.Location = new Point(8, 111);
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
            comboBox1.Location = new Point(78, 108);
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(324, 222);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Contact";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Menu;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(324, 222);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Permissions";
            // 
            // Operator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 309);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Operator";
            Text = "Operators";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}