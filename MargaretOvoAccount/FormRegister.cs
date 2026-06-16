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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        FormMain frmMain;

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;
            try
            {
                string inputName = textBoxName.Text;
                string inputPhoneNum = textBoxPhoneNumber.Text;
                string inputPin = textBoxPIN.Text;
                string inputOvoId = textBoxOvoID.Text;
                MargaretOvoAccout myAccount = new MargaretOvoAccout(inputName, inputOvoId, inputPhoneNum, inputPin);

                bool uniqueCheck = true;
                foreach (MargaretOvoAccout acc in frmMain.listOVOAcc)
                {
                    if (acc.OvoId == myAccount.OvoId)
                    {
                        uniqueCheck = false;
                        MessageBox.Show("OVO ID already exist!");
                        //throw new Exception("OVO ID already exist!");
                    }
                }

                if (uniqueCheck == true)
                {
                    frmMain.listOVOAcc.Add(myAccount);

                    MessageBox.Show("Berhasil Register!");

                    textBoxName.Text = "";
                    textBoxPhoneNumber.Text = "";
                    textBoxPIN.Text = "";
                    textBoxOvoID.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
