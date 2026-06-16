using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MargaretConcertApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public BindingList<MargaretConcert> listConcert = new BindingList<MargaretConcert>();

        private void AddConcertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput form = new FormInput();
            form.Owner = this;
            form.ShowDialog();
        }

        private void DisplayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplay form = new FormDisplay();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
