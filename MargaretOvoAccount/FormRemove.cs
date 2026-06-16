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
    public partial class FormRemove : Form
    {
        public FormRemove()
        {
            InitializeComponent();
        }

        FormMain frmMain;
        MargaretOvoAccout selectedAccount;

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                DialogResult result = MessageBox.Show("Are you sure to remove this account?" + selectedAccount.DisplayData(), "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    frmMain.listOVOAcc.Remove(selectedAccount);
                    MessageBox.Show("Account is succesfully removed");
                }
                else
                {
                    MessageBox.Show("Acount removal is cancelled");
                }
            }
        }

        private void FormRemove_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;

            comboBoxAccount.DataSource = frmMain.listOVOAcc;
            comboBoxAccount.DisplayMember = "OvoId";
            comboBoxAccount.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ComboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = (MargaretOvoAccout)comboBoxAccount.SelectedItem;
        }
    }
}
