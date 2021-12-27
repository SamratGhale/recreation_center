using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recreation_center
{
    
    public partial class Form2 : Form
    {
        private GroupsArray menuArr;
        String userName;

        public Form2(String _userName)
        {
            InitializeComponent();
            this.userName = _userName;
            userNameLabel.Text = _userName;
            menuArr = new GroupsArray();
            RefreshMenu();
            if(userName != "Admin")
            {
                UpdateMenu.Hide();
            }
        }

        void RefreshMenu(){
            MenuTable.Rows.Clear();
            foreach (GroupRates gr in menuArr.groupArr)
            {
                MenuTable.Rows.Add(gr.getRowValues());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
        protected override void OnClosed(EventArgs e)
        {
            MessageBox.Show("The form is now closing.",
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            base.OnClosed(e);
            Application.Exit();
        }

        private void UpdateMenu_Click(object sender, EventArgs e)
        {
            (new UpdateRate(ref menuArr)).Show();
            //this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void saveRateButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.RestoreDirectory = true;
            SaveFileDialog1.InitialDirectory = ".";
            if(SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(SaveFileDialog1.FileName.ToString(), FileMode.Create, FileAccess.Write);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, menuArr);
                stream.Close();
            }
        }
    }
}
