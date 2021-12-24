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
        public UpdateRate(GroupsArray menuArray)
        {
            InitializeComponent();
            foreach (GroupRates gr in menuArray.groupArr)
            {
                groupDropDown.Items.Add(gr.getRowValues()[0]);
            }
            menuArray.groupArr.Add(new GroupRates(GroupType.Adult, true));
            groupDropDown.SelectedIndex= 0;
        }
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void groupDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
