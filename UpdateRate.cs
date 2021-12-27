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
            _menuArray.groupArr.Add(new GroupRates(GroupType.Adult, true));
            groupDropDown.SelectedIndex= 0;
        }
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void groupDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupRates gr       = menuArray.groupArr[groupDropDown.SelectedIndex];

            oneHourText.Text    = gr.Rate.One_hr.ToString();
            twoHoursText.Text   = gr.Rate.Two_hr.ToString();
            fourHoursText.Text  = gr.Rate.Four_hr.ToString();
            wholeDayText.Text   = gr.Rate.Whole_day.ToString();

        }
    }
}
