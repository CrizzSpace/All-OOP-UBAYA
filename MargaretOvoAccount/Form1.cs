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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MargaretOvoAccout myAccount;
        MargaretOvoAccout selectedAcc;
        BindingList<MargaretOvoAccout> listAccount = new BindingList<MargaretOvoAccout>();

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string inputName = textBoxName.Text;
                string inputPhoneNum = textBoxPhoneNumber.Text;
                string inputPin = textBoxPIN.Text;
                string inputOvoId = textBoxOvoID.Text;
                myAccount = new MargaretOvoAccout(inputName, inputOvoId, inputPhoneNum, inputPin);

                bool uniqueCheck = true;
                foreach (MargaretOvoAccout acc in listAccount)
                {
                    if (acc.OvoId == myAccount.OvoId)
                    {
                        uniqueCheck = false;
                        MessageBox.Show("OVO ID already exist!");
                        //throw new Exception("OVO ID already exist!");
                    }
                }

                if(uniqueCheck == true)
                {
                    listBoxData.Items.Clear();
                    listBoxData.Items.AddRange(myAccount.DisplayData().Split('\n'));
                    listAccount.Add(myAccount);
                }

                textBoxName.Text = "";
                textBoxPhoneNumber.Text = "";
                textBoxPIN.Text = "";
                textBoxOvoID.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                int topUp = int.Parse(textBoxNominalTopUp.Text);
                selectedAcc.TopUp(topUp);

                listBoxData.Items.Clear();
                listBoxData.Items.AddRange(selectedAcc.DisplayData().Split('\n'));
                textBoxNominalTopUp.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                string itemType = comboBoxItems.Text;
                int itemPrice = int.Parse(textBoxPrice.Text);
                selectedAcc.Buy(itemType, itemPrice);

                listBoxData.Items.Clear();
                listBoxData.Items.Add("Pembelian Berhasil!");
                listBoxData.Items.AddRange(selectedAcc.DisplayData().Split('\n'));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDisplayData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            foreach (MargaretOvoAccout acc in listAccount)
            {
                listBoxData.Items.AddRange(acc.DisplayData().Split('\n'));
            }

        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSelectAccount.DataSource = listAccount;
            comboBoxSelectAccount.DisplayMember = "Name";
        }

        private void ComboBoxSelectAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAcc = (MargaretOvoAccout)comboBoxSelectAccount.SelectedItem;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            listAccount.Remove(selectedAcc);

            DialogResult result = MessageBox.Show("Are you sure to remove this account?" + selectedAcc.DisplayData(), "Confirmation", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Account is succesfully removed");
            }
            else
            {
                MessageBox.Show("Acount removal is cancelled");
            }
        }
    }
}
