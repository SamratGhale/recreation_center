using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace recreation_center
{
    //Enums for AgeGroup
    public enum GroupType
    {
        [Description("Child (<3)")]
        Child,
        [Description("Teen  (3-16)")]
        Teen,
        [Description("Adult (16-60)")]
        Adult,
        [Description("Elder (60+)")]
        Elder
    }
    public class Rates{
        public int One_hr     {get;set;}
        public int Two_hr     {get;set;}
        public int Three_hr   {get;set;}
        public int Four_hr    {get;set;}
        public int Whole_day  {get;set;}

        public Rates(int one_hr, int two_hr, int three_hr, int four_hr, int whole_day)
        {
            this.One_hr = one_hr;
            this.Two_hr = two_hr;
            this.Three_hr = three_hr;
            this.Four_hr = four_hr;
            this.Whole_day = whole_day;
        }
        public void resetRates(int one_hr, int two_hr, int three_hr, int four_hr, int whole_day)
        {
            this.One_hr = one_hr;
            this.Two_hr = two_hr;
            this.Three_hr = three_hr;
            this.Four_hr = four_hr;
            this.Whole_day = whole_day;
        }
        public Rates(){
            this.One_hr = 0;
            this.Two_hr = 0;
            this.Three_hr = 0;
            this.Four_hr = 0;
            this.Whole_day = 0;
        }
        public string[] getRatesArray()
        {
            string[] ret = { One_hr.ToString(), Two_hr.ToString(), Three_hr.ToString(), Four_hr.ToString(), Whole_day.ToString() };
            return ret;
        }
    }

    public class GroupRates
    {
        //Variables
        private GroupType Age       { get; set; }
        private bool      IsWeekend { get; set; }
        private int       GroupSize { get; set; }
        private Rates     Rate      { get; set; }

        //Constructor
        public GroupRates(GroupType ageGroup, bool isWeekend, int groupSize)
        {
            this.Age       = ageGroup;
            this.IsWeekend = isWeekend;
            this.GroupSize = groupSize;
            this.Rate      = new Rates();
        }
        public String[] getRowValues()
        {
            String[] ret =   { Age.ToString() + "Group of" +  GroupSize.ToString() };
            ret.Concat(Rate.getRatesArray());
            return ret;
        }
    }

    class GroupsArray{
        public List<GroupRates> groupArr;

        public GroupsArray(){
            groupArr = new List<GroupRates>();
            foreach(GroupType gt in Enum.GetValues(typeof(GroupType))){
                groupArr.Add(new GroupRates(gt, false, 1 ));
                groupArr.Add(new GroupRates(gt, false, 10));
                groupArr.Add(new GroupRates(gt, false, 5 ));
                groupArr.Add(new GroupRates(gt, false, 20));
                groupArr.Add(new GroupRates(gt, false, 21));
            }
        }
    }
}
