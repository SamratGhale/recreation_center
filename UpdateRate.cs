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
    public partial class UpdateRate : Form
    {
        GroupsArray menuArray;
        public UpdateRate(ref GroupsArray _menuArray)
        {
            InitializeComponent();
            foreach (GroupRates gr in _menuArray.groupArr)
            {
                groupDropDown.Items.Add(gr.getRowValues()[0]);
            }
            this.menuArray = _menuArray;
            groupDropDown.SelectedIndex= 0;
        }

        private void groupDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupRates gr      = menuArray.groupArr[groupDropDown.SelectedIndex];
            oneHourNum.Text    = gr.Rate.One_hr.ToString();
            twoHoursNum.Text   = gr.Rate.Two_hr.ToString();
            fourHoursNum.Text  = gr.Rate.Four_hr.ToString();
            wholeDayNum.Text   = gr.Rate.Whole_day.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupRates gr = menuArray.groupArr[groupDropDown.SelectedIndex];
            gr.Rate.One_hr    = int.Parse(oneHourNum.Text);
            gr.Rate.Two_hr    = int.Parse(twoHoursNum.Text);
            gr.Rate.Four_hr   = int.Parse(fourHoursNum.Text);
            gr.Rate.Whole_day = int.Parse(wholeDayNum.Text);
            MessageBox.Show("The rates were updated",
    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
