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

namespace MargaretEmployeeApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public BindingList<MargaretEmployee> listEmployee = new BindingList<MargaretEmployee>();
        public int lastId = 0;

        private void AddNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee form = new FormAddNewEmployee();
            form.Owner = this;
            form.ShowDialog();
        }

        private void DisplayAllEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayAllEmployees form = new FormDisplayAllEmployees();
            form.Owner = this;
            form.ShowDialog();
        }

        private void CalculateIncentiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculateIncentive form = new FormCalculateIncentive();
            form.Owner = this;
            form.ShowDialog();
        }
        public void LoadFromFile(string dataName)
        {
            if (File.Exists(dataName))
            {
                FileStream fs = new FileStream(dataName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                listEmployee = (BindingList<MargaretEmployee>)bf.Deserialize(fs);
                fs.Close();
            }
        }
        public void SaveToFile(string dataName)
        {
            FileStream fs = new FileStream(dataName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listEmployee);
            fs.Close();
        }
        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Data File (*.dat)|*.dat";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadFromFile(dialog.FileName);
                MessageBox.Show("Your data has been loaded from " + dialog.FileName);

                lastId = 0;
                foreach (MargaretEmployee emp in listEmployee)
                {
                    if (emp.Id > lastId)
                    {
                        lastId = emp.Id;
                    }
                }
            }
        }

        public void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Data File (*.dat)|*.dat";
            dialog.FileName = "employee.dat";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(dialog.FileName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
