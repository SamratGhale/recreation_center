using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recreation_center
{
    [Serializable]
    public class Visitor
    {
        //TO diffrinciate all the visitors like a primary key
        public int VisitorId    { get; set; }

        //Visitor's name
        public string Name      { get; set; }

        //The group/age type of the visitor
        public GroupType Type   { get; set; }
        public bool IsWeekend   { get; set; }
        public bool Completed   { get; set; }
        public DateTime InTime  { get; set; }
        public DateTime OutTime { get; set; }
        public DateTime Date    { get; set; }
        public double TotalFee  { get; set; }

        public Visitor(int _visitorId, string _name, GroupType _type,DateTime _date, DateTime _InTime, DateTime _OutTime, bool _isWeeknd)
        {
            this.VisitorId = _visitorId;
            this.Date = _date;
            this.Name = _name;
            this.Type = _type;
            this.InTime = _InTime;
            this.OutTime = _OutTime;
            this.IsWeekend = _isWeeknd;
            this.Completed = true;
            this.TotalFee  = 0;
        }
        public Visitor(int _visitorId, string _name, GroupType _type, DateTime _date, DateTime _InTime, bool _isWeeknd)
        {
            this.VisitorId = _visitorId;
            this.Date = _date;
            this.Name = _name;
            this.Type = _type;
            this.InTime = _InTime;
            this.IsWeekend = _isWeeknd;
            this.Completed = false;
            this.TotalFee  = 0;
        }
        public Visitor()
        {
        }
        /*
         *for adding in the table, 
         *if the checkout isn't completed then there can't be checkout time so we have to look for different cases
         */
        public string[] getValues(){
            if (!Completed)
            {
                string[] ret = { this.VisitorId.ToString(), this.Name,((GroupType)this.Type).AsString(EnumFormat.Description),    IsWeekend.ToString(), Completed.ToString(), InTime.ToShortTimeString(), "", Date.ToShortDateString()};
                return ret;
            }
            else
            {
                string[] ret = { this.VisitorId.ToString(), this.Name,((GroupType)this.Type).AsString(EnumFormat.Description),    IsWeekend.ToString(), Completed.ToString(), InTime.ToShortTimeString(), OutTime.ToShortTimeString(), Date.ToShortDateString(), TotalFee.ToString()};
                return ret;
            }
        }
    }
}
