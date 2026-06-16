using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MargaretEmployeeApplication
{
    public partial class FormDisplayAllEmployees : Form
    {
        public FormDisplayAllEmployees()
        {
            InitializeComponent();
        }
        FormMain frmMain;
        private void FormDisplayAllEmployees_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;

            foreach(MargaretEmployee employee in frmMain.listEmployee)
            {
                listBoxInfo.Items.AddRange(employee.DisplayData().Split('\n'));
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
