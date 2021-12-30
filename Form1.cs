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
    public partial class Checkout : Form
    {
        public Visitor v;
        public GroupsArray menuArr;
        public Checkout(GroupsArray _menuArr,ref Visitor _v)
        {
            InitializeComponent();
            this.v = _v;
            VisitorId.Text   = _v.VisitorId.ToString();
            visitorName.Text = _v.Name;
            date.Value = _v.Date;
            IsWeekend.Checked = _v.IsWeekend;
            checkInTime.Value = _v.InTime;
            if (_v.Completed)
            {
                statusBox.SelectedIndex = 0;
                checkOutTime.Value = _v.OutTime;
            }
            else
            {
                statusBox.SelectedIndex = 1;
                TotalFeeLabel.Visible = false;
                checkOutTime.Visible = false;
                checkOutLabel.Visible = false;
                TotalFee.Visible = false;
            }
            foreach (GroupRates gr in _menuArr.groupArr)
            {
                ageGroupType.Items.Add(gr.getRowValues()[0]);
            }
            this.menuArr = _menuArr;
            ageGroupType.SelectedIndex= ((int)_v.Type);
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(statusBox.SelectedIndex == 0)
            {
                TotalFeeLabel.Visible = true;
                checkOutTime.Visible  = true;
                checkOutLabel.Visible = true;
                TotalFee.Visible      = true;
            }
            else
            {
                TotalFeeLabel.Visible = false;
                checkOutTime.Visible = false;
                checkOutLabel.Visible = false;
                TotalFee.Visible = false;
            }
        }

        private void saveDetailsButton_Click(object sender, EventArgs e)
        {
            this.v.Name = visitorName.Text;
            this.v.Type = (GroupType)ageGroupType.SelectedIndex;
            this.v.Date = date.Value;
            this.v.InTime = checkInTime.Value;
            this.v.IsWeekend = IsWeekend.Checked;
            if(statusBox.SelectedIndex == 0)
            {
                this.v.OutTime = checkOutTime.Value;
                this.v.Completed = true;
                this.v.TotalFee = menuArr.GetTotal(this.v);
            }
            else
            {
                this.v.Completed = false;
                this.v.TotalFee = 0;
            }
        }
    }
}
