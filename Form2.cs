using EnumsNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace recreation_center
{

    public partial class Form2 : Form
    {
        private GroupsArray menuArr;
        private List<Visitor> visitors;

        private bool isIncomeSort;

        String userName;

        public Form2(String _userName)
        {
            InitializeComponent();
            this.userName = _userName;
            userNameLabel.Text = _userName;
            menuArr = new GroupsArray();
            visitors = new List<Visitor>();
            menuArr.initilizeWithZero();
            
            if (userName != "Admin")
            {
                UpdateMenu.Enabled = false;
                refreshButton.Enabled = false;
                menuItem4.Enabled = false;
            }else
            {
            }
            foreach (GroupRates gr in menuArr.groupArr)
            {
                ageGroupBox.Items.Add(gr.getRowValues()[0]);
            }
            ageGroupBox.SelectedIndex = 0;
            init();
            RefreshMenu();
            RefreshRecords();
            refreshChart();
            refreshWeeklyChart();
            isIncomeSort = true;
            ByTotalIncome.Checked = true;
        }

        void RefreshMenu() {
            try
            {
                Stream stream = new FileStream("../../../MenuSavedData.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer formatter = new XmlSerializer(typeof(GroupsArray));
                formatter.Serialize(stream, menuArr);
                stream.Close();
            }
            catch(Exception e)
            {
            MessageBox.Show("Couldn't open or serealize the file MenuSavedData.xml your your Menu is not being saved.\n" + e.Message,
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            MenuTable.Rows.Clear();
            foreach (GroupRates gr in menuArr.groupArr)
            {
                MenuTable.Rows.Add(gr.getRowValues());
            }
        }

        void RefreshRecords() {
            try
            {
                Stream stream = new FileStream("../../../VisitorSavedData.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Visitor>));
                formatter.Serialize(stream, visitors);
                stream.Close();
            }
            catch(Exception e)
            {
            MessageBox.Show("Couldn't open or serealize the file VisitorSavedData.xml your your visitor is not being saved.\n" + e.Message,
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            VisitorTable.Rows.Clear();
            foreach (Visitor vr in visitors)
            {
                VisitorTable.Rows.Add(vr.getValues());
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
                try
                {
                    Stream stream = new FileStream(SaveFileDialog1.FileName.ToString(), FileMode.Create, FileAccess.Write);
                    XmlSerializer formatter = new XmlSerializer(typeof(GroupsArray));
                    formatter.Serialize(stream, menuArr);
                    stream.Close();
                }
                catch(Exception err)
                {
                MessageBox.Show("Couldn't open or deserealize the file  " + SaveFileDialog1.FileName + ".\n" + err.Message,
                    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void init() {

            XmlSerializer serializer = new XmlSerializer(typeof(GroupsArray));
            try
            {
                using (Stream reader = new FileStream("../../../MenuSavedData.xml", FileMode.Open, FileAccess.Read))
                {
                    GroupsArray newArr = (GroupsArray)serializer.Deserialize(reader);
                    this.menuArr = newArr;
                }
            }
            catch(Exception err)
            {
            MessageBox.Show("Couldn't open or deserealize the file MenuSavedData.xml your Menu will be empty.\n" + err.Message,
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            XmlSerializer serializer1 = new XmlSerializer(typeof(List<Visitor>));
            try
            {
                using (Stream reader = new FileStream("../../../VisitorSavedData.xml", FileMode.Open, FileAccess.Read))
                {
                    visitors = (List<Visitor>)serializer1.Deserialize(reader);
                }
            }
            catch(Exception err)
            {
            MessageBox.Show("Couldn't open or deserealize the file VisitorSavedData.xml your visitors will be empty.\n" + err.Message,
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                var csv = new StringBuilder();
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
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (Stream reader = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    GroupsArray newArr = (GroupsArray)serializer.Deserialize(reader);
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
            GroupsArray m = new GroupsArray();
            m.groupArr = new List<GroupRates>();
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try { 
                using (StreamReader reader = new StreamReader(dlg.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        Rates r = new Rates(values.Skip(1).ToList().Select(int.Parse).ToList());

                        GroupType gt = Enum.GetValues(typeof(GroupType)).Cast<GroupType>().First(item => item.AsString(EnumFormat.Description) == values[0]);
                        m.groupArr.Add(new GroupRates(gt, r));
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Couldn't open or deserealize the file "+dlg.FileName + ".\n" + err.Message,
                    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            menuArr = m;
            RefreshMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (completedBox.Checked)
            {
                Visitor v = new Visitor(visitors.Count + 1, visitorNameBox.Text, (GroupType)ageGroupBox.SelectedIndex, DatePicker.Value, checkInBox.Value, checkOutBox.Value, isWeekendBox.Checked);
                v.TotalFee = menuArr.GetTotal(v);
                this.visitors.Add(v);
            } else {
                Visitor v = new Visitor(visitors.Count + 1, visitorNameBox.Text, (GroupType)ageGroupBox.SelectedIndex, DatePicker.Value, checkInBox.Value, isWeekendBox.Checked);
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
            if (e.RowIndex == -1)
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

        private void menuItem11_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(SaveFileDialog1.FileName.ToString(), FileMode.Create, FileAccess.Write);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Visitor>));
                formatter.Serialize(stream, visitors);
                stream.Close();
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GroupsArray));

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (Stream reader = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    this.visitors = (List<Visitor>)serializer.Deserialize(reader);
                }
            }

        }
        void refreshChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.Padding = new Padding(3, 3, 3, 3);
            chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            double totalIncomeDouble = 0;
            foreach (Visitor v in visitors) if (v.Date == dateTimePicker1.Value.Date)
                {
                    totalIncomeDouble += v.TotalFee;
                }
            int max = 1;
            foreach (GroupRates gr in menuArr.groupArr)
            {
                Series series = this.chart1.Series.Add(gr.getRowValues()[0]);
                series["PixelPointWidth"] = "400";
                int count = 0;
                foreach (Visitor v in visitors)
                {
                    if (v.Type == gr.Age && v.Date.Date.ToShortDateString() == dateTimePicker1.Value.Date.ToShortDateString())
                    {
                        count += 1;
                    }
                }
                if (count >= max)
                {
                    max = count;
                }
                series.Points.Add(count);
            }
            //chart1.ChartAreas[0].AxisX.Maximum = menuArr.groupArr.Count;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = max;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            TotalIncome.Text = totalIncomeDouble.ToString();
        }


        private void menuItem14_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var csv = new StringBuilder();
                List<string> titles = new List<string>();
                foreach (PropertyInfo prop in (new Visitor()).GetType().GetProperties())
                {
                    titles.Add(prop.Name);
                }
                csv.AppendLine(string.Join(",", titles));

                foreach (Visitor v in visitors)
                {
                    csv.AppendLine(string.Join(",", v.getValues()));
                }
                File.WriteAllText(SaveFileDialog1.FileName.ToString(), csv.ToString());
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            refreshChart();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {

            List<Visitor> newVisitors = new List<Visitor>();


            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                using (StreamReader reader = new StreamReader(dlg.FileName))
                {
                    string line = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        Visitor v = new Visitor();
                        line = reader.ReadLine();
                        string[] values = line.Split(',');

                        v.VisitorId = int.Parse(values[0]);
                        v.Name = values[1];
                        v.Type = Enum.GetValues(typeof(GroupType)).Cast<GroupType>().First(item => item.AsString(EnumFormat.Description) == values[2]);
                        v.IsWeekend = bool.Parse(values[3]);
                        v.Completed = bool.Parse(values[4]);
                        v.InTime = DateTime.Parse(values[5]);
                        v.Date = DateTime.Parse(values[7]);
                        if (v.Completed)
                        {
                            v.OutTime = DateTime.Parse(values[6]);
                            v.TotalFee = double.Parse(values[8]);
                        }
                        else
                        {
                        }
                        newVisitors.Add(v);
                    }

                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Couldn't open or deserealize the file "+dlg.FileName + ".\n" + err.Message,
                    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            visitors = newVisitors;
            refreshChart();
            refreshWeeklyChart();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshChart();
        }

        void refreshWeeklyChart()
        {
            DateTime date = WeeklyDatePicker.Value.Date; 
            int year = date.Date.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);

            StartDateLabel.Text = startDateOfWeek.ToShortDateString();
            EndDateLabel.Text   = endDateOfWeek.ToShortDateString();

            DateTime currDate = startDateOfWeek;

            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday" };

            int index = 0;

            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.Padding = new Padding(3, 3, 3, 3);
            chart2.ChartAreas[0].AxisY.IsMarginVisible = false;
            chart2.ChartAreas[0].AxisX.IsMarginVisible = false;

            double totalIncomeDouble = 0;
            foreach (Visitor v in visitors) if (v.Date <= startDateOfWeek.Date  && v.Date >= endDateOfWeek.Date  )
            {
                totalIncomeDouble += v.TotalFee;
            }


            List<WeekInfo> weeks = new List<WeekInfo>();

            while(currDate.Date <= endDateOfWeek)
            {

                int count = 0;
                double totalIncome = 0;

                foreach (Visitor v in visitors)
                {
                    if (v.Date.Date.ToShortDateString() == currDate.Date.ToShortDateString())
                    {
                        count += 1;
                        totalIncome += v.TotalFee;
                    }
                }

                weeks.Add(new WeekInfo(daysOfWeek[index], count, totalIncome));


                currDate = currDate.AddDays(1);
                index += 1;
            }

            if (isIncomeSort)
            {
                weeks = BubbleSortClass.BubbleSort(weeks,  BubbleSortClass.CompareIncome);
            }
            else
            {
                weeks = BubbleSortClass.BubbleSort(weeks, BubbleSortClass.CompareNumOfVisitors);
            }

            foreach (WeekInfo week in weeks)
            {
                Series series = this.chart2.Series.Add(week.Name + " "+ (isIncomeSort ? week.TotalIncome : week.NumOfVisitors));
                series["PixelPointWidth"] = "400";
                series.Points.Add(isIncomeSort ? week.TotalIncome : week.NumOfVisitors);
                series.ChartType = SeriesChartType.Bar;
            }
                //chart1.ChartAreas[0].AxisX.Maximum = menuArr.groupArr.Count;
                chart2.ChartAreas[0].AxisX.Minimum = 0;
                
                chart2.ChartAreas[0].AxisY.Maximum = weeks.Max(i => (isIncomeSort ? i.TotalIncome : i.NumOfVisitors));
                chart2.ChartAreas[0].AxisY.Minimum = 0;
                //TotalIncome.Text = totalIncomeDouble.ToString();

        }



        private void WeeklyDatePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshWeeklyChart();
        }

        private void ByVisitor_CheckedChanged(object sender, EventArgs e)
        {
            this.isIncomeSort = !ByVisitor.Checked;
            refreshWeeklyChart();
        }

        private void ByTotalIncome_CheckedChanged(object sender, EventArgs e)
        {
            this.isIncomeSort = ByTotalIncome.Checked;
            refreshWeeklyChart();
        }
    }
}
