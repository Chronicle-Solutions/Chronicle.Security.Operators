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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            DialogResult res = s.ShowDialog();
            if (res != DialogResult.OK) return;
            Operator o = new Operator(false);
            o.OperatorID = s.OperatorID;
            o.MdiParent = this;
            o.Show();

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Operator o = new Operator(true);
            o.MdiParent = this;
            o.Show();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Get current Mdi Child
            if (ActiveMdiChild is not Operator opr) return;
            opr.doSave(null, null);
        }
    }
}
