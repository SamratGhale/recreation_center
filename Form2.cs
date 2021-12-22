using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            InitilizeMenu();
        }
        void InitilizeMenu()
        {
            foreach(GroupRates gr in menuArr.groupArr)
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


    }
}
