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
    public partial class OperatorForm : Form
    {

        public OperatorForm()
        {
            InitializeComponent();
            MenuUtils.populateMenu(menuToolStripMenuItem.DropDownItems, "/");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Operator o = new Operator(true);
            o.MdiParent = this;
            o.Show();
        }
    }
}
