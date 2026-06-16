using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MargaretOvoAccount
{
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
        }

        FormMain frmMain;

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;

            listBoxData.Items.Clear();
            int i = 0;
            foreach (MargaretOvoAccout acc in frmMain.listOVOAcc)
            {
                i++;
                listBoxData.Items.Add("=== ACCOUNT " + i + " ===");
                listBoxData.Items.AddRange(acc.DisplayData().Split('\n'));
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
