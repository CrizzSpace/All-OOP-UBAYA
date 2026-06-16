using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MargaretOvoAccount
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public BindingList<MargaretOvoAccout> listOVOAcc = new BindingList<MargaretOvoAccout>();
        private void RegisterNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.Owner = this;
            form.ShowDialog();
        }

        private void DisplayAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplay form = new FormDisplay();
            form.Owner = this;
            form.ShowDialog();
        }

        private void RemoveAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemove form = new FormRemove();
            form.Owner = this;
            form.ShowDialog();
        }

        private void TopUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTopUp form = new FormTopUp();
            form.Owner = this;
            form.ShowDialog();
        }

        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuy form = new FormBuy();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadFromFile(string dataName)
        {
            if (File.Exists(dataName))
            {
                FileStream fs = new FileStream(dataName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                listOVOAcc = (BindingList<MargaretOvoAccout>)bf.Deserialize(fs);
                fs.Close();
            }
        }
        public void SaveToFile(string dataName)
        {
            FileStream fs = new FileStream(dataName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listOVOAcc);
            fs.Close();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Data File (*.acc)|*.acc";
            dialog.FileName = "newOvo.acc";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(dialog.FileName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Data File (*.acc)|*.acc";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadFromFile(dialog.FileName);
                MessageBox.Show("Your data has been loaded from " + dialog.FileName);
            }
        }
    }
}
