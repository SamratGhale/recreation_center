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

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../Logins.xml");

            XmlNodeList nodeList;

            String inseredUserName = userNameInput.Text;
            String inseredPassword = passwordInput.Text;

            if(inseredPassword == "" || inseredUserName == "")
            {
                MessageBox.Show("Username or password in empty.",
    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

 

            String password = "";
            String userName = "";

            if(isAdmin.Checked)
            {
                nodeList = xmlDoc.SelectNodes("/users/Admin");
                userName = nodeList[0].SelectSingleNode("username").InnerText;
                password = nodeList[0].SelectSingleNode("password").InnerText;
            }
            else
            {
                nodeList = xmlDoc.SelectNodes("/users/Staff");
                foreach(XmlNode node in nodeList)
                {
                    if(inseredUserName.Equals(node.SelectSingleNode("username").InnerText))
                    {
                        userName = node.SelectSingleNode("username").InnerText;
                        password = node.SelectSingleNode("password").InnerText;
                        break;
                    }
                }
                if(password.Equals(""))
                {
                    MessageBox.Show("Username not found! Try again or check the admin box if you are admin",
        "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            if(inseredPassword.Equals(password) && inseredUserName.Equals(userName))
            {
                MessageBox.Show("Login successfull.",
    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                f2 = new Form2(userName);
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

        }
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
