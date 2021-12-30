using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using EnumsNET;

namespace recreation_center
{
    //Enums for AgeGroup
    [Serializable]
    public enum GroupType
    {
        [Description("Child (<3)")]
        Child,
        [Description("Teen  (3-16)")]
        Teen,
        [Description("Adult (16-60)")]
        Adult,
        [Description("Elder (60+)")]
        Elder,
        [Description("Group of 5")]
        GroupOfFive,
        [Description("Group of 10")]
        GroupOfTen,
        [Description("Group of 15")]
        GroupOfFifteen,
        [Description("Group of 20")]
        GroupOfTwenty
    }
    [Serializable]
    public class Rates{
        public int One_hr     {get;set;}
        public int Two_hr     {get;set;}
        public int Four_hr    {get;set;}
        public int Whole_day  {get;set;}

        public Rates(int one_hr, int two_hr, int four_hr, int whole_day)
        {
            this.One_hr = one_hr;
            this.Two_hr = two_hr;
            this.Four_hr = four_hr;
            this.Whole_day = whole_day;
        }
        public void resetRates(int one_hr, int two_hr,  int four_hr, int whole_day)
        {
            this.One_hr = one_hr;
            this.Two_hr = two_hr;
            this.Four_hr = four_hr;
            this.Whole_day = whole_day;
        }
        public Rates(){
            this.One_hr = 0;
            this.Two_hr = 0;
            this.Four_hr = 0;
            this.Whole_day = 0;
        }
        public string[] getRatesArray()
        {
            string[] ret = { One_hr.ToString(), Two_hr.ToString(), Four_hr.ToString(), Whole_day.ToString() };
            return ret;
        }
    }

    [Serializable]
    public class GroupRates
    {
        //Variables
        public GroupType Age       { get; set; }
        public Rates      Rate      { get; set; }

        //Constructor
        public GroupRates(GroupType ageGroup)
        {
            this.Age       = ageGroup;
            this.Rate      = new Rates();
        }
        private GroupRates()
        {

        }
        public String[] getRowValues()
        {
            String[] ret =   { ((GroupType)Age).AsString(EnumFormat.Description) };
            ret          =   ret.Concat(Rate.getRatesArray()).ToArray();
            return ret;
        }

    }

    [Serializable]
    public class GroupsArray{
        public List<GroupRates> groupArr;

        public GroupsArray(){

        }
        //Initilizes the group array with zero
        public void initilizeWithZero()
        {
            groupArr = new List<GroupRates>();
            foreach (GroupType gt in Enum.GetValues(typeof(GroupType)))
            {
                groupArr.Add(new GroupRates(gt));
            }
        }
        public double GetTotal(Visitor visitor){
            double price = 0;
            if(visitor.Completed == false){
                return -1;
            }
            foreach(GroupRates gr in groupArr){
                if(gr.Age == visitor.Type){
                    TimeSpan result = visitor.OutTime.Subtract(visitor.InTime);
                    if(result.Hours <= 1){
                        price = gr.Rate.One_hr; 
                    }
                    else if(result.Hours <= 2){
                        price = gr.Rate.Two_hr; 
                    }
                    else if(result.Hours <= 4){
                        price = gr.Rate.Four_hr; 
                    }
                    else {
                        price = gr.Rate.Whole_day; 
                    }
                }
            }
            if(visitor.IsWeekend){
                price += price * 0.2;
            }
            return price;
        }
    }
}
