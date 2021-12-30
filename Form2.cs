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
using System.Xml.Serialization;

namespace recreation_center
{
    
    public partial class Form2 : Form
    {
        private GroupsArray menuArr;
        private List<Visitor> visitors;

        String userName;

        public Form2(String _userName)
        {
            InitializeComponent();
            this.userName = _userName;
            userNameLabel.Text = _userName;
            menuArr = new GroupsArray();
            visitors = new List<Visitor>();
            menuArr.initilizeWithZero();
            if(userName != "Admin")
            {
                UpdateMenu.Hide();
            }
            foreach (GroupRates gr in menuArr.groupArr)
            {
                ageGroupBox.Items.Add(gr.getRowValues()[0]);
            }
            ageGroupBox.SelectedIndex = 0;
            init();
            RefreshMenu();
            RefreshRecords();
        }

        void RefreshMenu(){
            MenuTable.Rows.Clear();
            foreach (GroupRates gr in menuArr.groupArr)
            {
                MenuTable.Rows.Add(gr.getRowValues());
            }
        }

        void RefreshRecords(){
            VisitorTable.Rows.Clear();
            foreach (Visitor vr in visitors)
            {
                VisitorTable.Rows.Add(vr.getValues());
                if (vr.Completed)
                {
                }
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
            (new UpdateRate(ref menuArr)).ShowDialog();
            //this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }
        private void menuItem5_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(SaveFileDialog1.FileName.ToString(), FileMode.Create, FileAccess.Write);
                XmlSerializer formatter = new XmlSerializer(typeof(GroupsArray));
                formatter.Serialize(stream, menuArr);
                stream.Close();
            }
        }

        void init(){
                visitors.Add(new Visitor(0, "samrat ghale", GroupType.Child, DateTime.Today,  DateTime.Now , DateTime.Now, true));
                visitors[visitors.Count-1].TotalFee = menuArr.GetTotal(visitors[visitors.Count-1]);
                visitors.Add(new Visitor(2, "samrat ghale", GroupType.Adult, DateTime.Today , DateTime.Now , DateTime.Now, false));
                visitors[visitors.Count-1].TotalFee = menuArr.GetTotal(visitors[visitors.Count-1]);
                visitors.Add(new Visitor(3, "samrat ghale", GroupType.Elder, DateTime.Today , DateTime.Now , DateTime.Now, true));
                visitors[visitors.Count-1].TotalFee = menuArr.GetTotal(visitors[visitors.Count-1]);
                visitors.Add(new Visitor(4, "samrat ghale", GroupType.GroupOfTen, DateTime.Today , DateTime.Now , DateTime.Now, true));
                visitors[visitors.Count-1].TotalFee = menuArr.GetTotal(visitors[visitors.Count-1]);
                visitors.Add(new Visitor(5, "samrat ghale", GroupType.Child, DateTime.Today , DateTime.Now ,  true));
                visitors.Add(new Visitor(6, "samrat ghale", GroupType.Child, DateTime.Today , DateTime.Now ,  false));
                visitors.Add(new Visitor(7, "samrat ghale", GroupType.Child, DateTime.Today , DateTime.Now ,  true));
                visitors.Add(new Visitor(8, "samrat ghale", GroupType.Child, DateTime.Today , DateTime.Now ,  true));
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(SaveFileDialog1.FileName.ToString(), FileMode.Create, FileAccess.Write);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, menuArr);
                stream.Close();
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var csv = new  StringBuilder();
                foreach (GroupRates gr in menuArr.groupArr)
                {
                    csv.AppendLine(string.Join(",", gr.getRowValues()));
                }
                File.WriteAllText(SaveFileDialog1.FileName.ToString(), csv.ToString());
            }

        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GroupsArray));

            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                using(Stream reader = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    GroupsArray newArr =  (GroupsArray)serializer.Deserialize(reader);
                    this.menuArr = newArr;
                }
            }
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (Stream reader = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    GroupsArray newArr = (GroupsArray)formatter.Deserialize(reader);
                    this.menuArr = newArr;
                }
            }
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (completedBox.Checked)
            {
                Visitor v = new Visitor(visitors.Count + 1, visitorNameBox.Text, (GroupType)ageGroupBox.SelectedIndex, DatePicker.Value, checkInBox.Value, checkOutBox.Value, isWeekendBox.Checked );
                v.TotalFee = menuArr.GetTotal(v);
                this.visitors.Add(v);
            }else{
                Visitor v = new Visitor(visitors.Count + 1,visitorNameBox.Text, (GroupType)ageGroupBox.SelectedIndex, DatePicker.Value, checkInBox.Value, isWeekendBox.Checked);
                this.visitors.Add(v);
            }
            RefreshRecords();
        }

        private void completedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (completedBox.Checked)
            {
                checkOutBox.Show();
                checkOutTimeLabel.Show();
            }
            else
            {
                checkOutBox.Hide();
                checkOutTimeLabel.Hide();
            }
        }

        private void VisitorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            Visitor v = visitors.First(item => item.VisitorId == int.Parse(VisitorTable.Rows[e.RowIndex].Cells[0].Value.ToString()));
            (new Checkout(menuArr, ref v)).ShowDialog();
        }

        private void refreshVisitors_Click(object sender, EventArgs e)
        {
            RefreshRecords();
        }
    }
}
