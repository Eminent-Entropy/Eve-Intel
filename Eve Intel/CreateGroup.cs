using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eve_Intel
{
    public partial class CreateGroup : Form
    {
        public CreateGroup()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string newDirectory = Path.Combine(Form1.mainPath, name);
            if (!Directory.Exists(newDirectory))
            {
                Directory.CreateDirectory(newDirectory);
                MessageBox.Show("Group Created");
                Close();
            }
            else
            {
                MessageBox.Show("There is already a group with this name");
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
