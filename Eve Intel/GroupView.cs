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
    public partial class GroupView : Form
    {
        string group;
        Form1 form1;
        string[] files;
        string activeFile = "";

        public GroupView(string choice, Form1 form)
        {
            InitializeComponent();
            group = choice;
            form1 = form;
        }

        public void refresh()
        {
            files = Directory.GetFiles(group);
            LstItems.Items.Clear();
            for (int i = 0; i != files.Count(); i++) LstItems.Items.Add(files[i]);
        }

        private void GroupView_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string newPath = Path.Combine(group, name);
            if (name != "" && !File.Exists(newPath)) File.Create(newPath).Close();
            refresh();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (activeFile != "")
            {
                string text = TxtInfo.Text;
                File.WriteAllText(activeFile, text);
                refresh();
            }
            else MessageBox.Show("error");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }

        private void LstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LstItems.SelectedIndex;
            if (index > 1)
            {
                string path = Path.Combine(group, LstItems.Items[index].ToString());
                TxtInfo.Text = File.ReadAllText(path);
                activeFile = path;
                refresh();
            }
        }
    }
}
