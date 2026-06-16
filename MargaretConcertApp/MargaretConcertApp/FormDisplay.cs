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
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
        }
        FormMain formMain;
        MargaretConcert selectedConcert;
        private void FormDisplay_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;

            comboBoxConcert.DataSource = formMain.listConcert;
            comboBoxConcert.DisplayMember = "Title";
            comboBoxConcert.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ComboBoxConcert_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConcert = (MargaretConcert)comboBoxConcert.SelectedItem;
        }

        private void ButtonThis_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxData.Items.Clear();
                listBoxData.Items.AddRange(selectedConcert.DisplayData().Split('\n'));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDisplayAll_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxData.Items.Clear();
                foreach (MargaretConcert data in formMain.listConcert)
                {
                    if (data.IsOver() == false)
                        listBoxData.Items.AddRange(data.DisplayData().Split('\n'));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonMonth_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxData.Items.Clear();
                foreach (MargaretConcert data in formMain.listConcert)
                {
                    if (data.ThisMonth())
                    {
                        listBoxData.Items.AddRange(data.DisplayData().Split('\n'));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
