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
    public partial class FormAddNewEmployee : Form
    {
        public FormAddNewEmployee()
        {
            InitializeComponent();
        }
        FormMain frmMain;
        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;
            textBoxEmployeeID.ReadOnly = true;
            radioButtonMale.Checked = true;
            int id = frmMain.lastId+1;
            textBoxEmployeeID.Text = id.ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxEmployeeID.Text);
                string name = textBoxName.Text;
                int basicSalary = (int)numericUpDownBasicSalary.Value;
                string gender = "";
                if(radioButtonMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                DateTime startingWork = dateTimePickerStartWork.Value;
                int numChild = (int)numericUpDownNumOfChild.Value;
                MargaretEmployee employee = new MargaretEmployee(id, name, basicSalary, gender, startingWork, numChild);
                frmMain.listEmployee.Add(employee);
                MessageBox.Show("Data has been saved");
                textBoxName.Text = "";
                numericUpDownNumOfChild.Value = 0;
                numericUpDownBasicSalary.Value = 1000000;
                textBoxEmployeeID.Text = (frmMain.lastId + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
