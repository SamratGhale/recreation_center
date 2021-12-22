using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recreation_center
{
    public partial class Login : Form
    {
        Form f2;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            XmlDocument doc= new XmlDocument();

            doc.Load("../../Logins.xml");

            XmlNode userName = doc.DocumentElement.SelectSingleNode("/users/Staff");
            foreach(XmlNode n in userName.ChildNodes)
            {
                Console.WriteLine(n.SelectSingleNode("/username").InnerText);
            }
            /*
            String inseredUserName = userNameInput.Text;
            String inseredPassword = passwordInput.Text;

            if(inseredPassword.Equals(password) && inseredUserName.Equals(userName))
            {
                MessageBox.Show("Login successfull.",
    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed Please try again.",
    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userNameInput.Clear();
                passwordInput.Clear();
            }
            
            */
        }
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
