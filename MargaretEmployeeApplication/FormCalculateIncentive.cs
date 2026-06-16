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
    public partial class FormCalculateIncentive : Form
    {
        public FormCalculateIncentive()
        {
            InitializeComponent();
        }
        FormMain frmMain;
        MargaretEmployee selectedEmployee;
        private void FormCalculateIncentive_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;
            comboBoxEmployeeId.DataSource = frmMain.listEmployee;
            comboBoxEmployeeId.DisplayMember = "Id";
            comboBoxEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ComboBoxEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEmployee = (MargaretEmployee)comboBoxEmployeeId.SelectedItem;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int latestTotalSalest = int.Parse(textBoxTotalSales.Text);
            int incentive = selectedEmployee.CalculateIncentive(latestTotalSalest);
            MessageBox.Show("Employee Id : " + selectedEmployee.Id + "\nName : " + selectedEmployee.Name + 
                "\nTotal Sales = " + latestTotalSalest + "\nIncentive = " + incentive);
            textBoxTotalSales.Text = "";
            comboBoxEmployeeId.SelectedIndex = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
