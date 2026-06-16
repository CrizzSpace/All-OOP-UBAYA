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
    public partial class FormTopUp : Form
    {
        public FormTopUp()
        {
            InitializeComponent();
        }

        FormMain frmMain;
        MargaretOvoAccout selectedAccount;

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTopUp_Load(object sender, EventArgs e)
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

        private void ButtonTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                int topUp = int.Parse(textBoxNominalTopUp.Text);
                selectedAccount.TopUp(topUp);

                textBoxNominalTopUp.Text = "";
                MessageBox.Show("Top Up Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
