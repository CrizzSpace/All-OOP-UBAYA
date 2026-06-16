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
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        FormMain formMain;

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string artist = textBoxArtist.Text;
                string title = textBoxTitle.Text;
                string venue = comboBoxVenue.Text;
                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;
                MargaretConcert concert = new MargaretConcert(artist, title, venue, startDate, endDate);

                bool uniqueCheck = true;
                foreach (MargaretConcert data in formMain.listConcert)
                {
                    if (data.Artist.ToLower() == concert.Artist.ToLower() && data.Title.ToLower() == concert.Title.ToLower())
                    {
                        uniqueCheck = false;
                        MessageBox.Show(title + " has been saved");
                        //throw new Exception(title + "has been saved");
                    }
                }
                if (uniqueCheck == true)
                {
                    formMain.listConcert.Add(concert);

                    MessageBox.Show("Saved Successfully!");

                    textBoxArtist.Text = "";
                    textBoxTitle.Text = "";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;
        }
    }
}
