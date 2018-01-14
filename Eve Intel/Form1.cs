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
    public partial class Form1 : Form
    {
        public static string mainPath = "C://Eve-intel";
        public string[] groups;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(mainPath)) Directory.CreateDirectory(mainPath);
            groups = Directory.GetDirectories(mainPath);
            for (int i = 0; i != groups.Count(); i++)
            {
                CmboxLoad.Items.Add(groups[i]);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CreateGroup form = new CreateGroup();
            form.Show();
        }

        private void CmboxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string group = Path.Combine(mainPath, CmboxLoad.Items[CmboxLoad.SelectedIndex].ToString());
            GroupView form = new GroupView(group, this);
            form.Show();
            Hide();
        }

        private void BtnRef_Click(object sender, EventArgs e)
        {
            groups = Directory.GetDirectories(mainPath);
            for (int i = 0; i != groups.Count(); i++)
            {
                CmboxLoad.Items.Add(groups[i]);
            }
        }
    }
}
