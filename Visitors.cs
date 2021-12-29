using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recreation_center
{
    public class Visitor
    {
        public GroupType Type { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public bool IsWeekend { get; set; }
        public string Name { get; set; }
        public DateTime Date{get; set;}
        public bool Completed { get; set; }

        public Visitor(string _name, GroupType _type,DateTime _date, DateTime _InTime, DateTime _OutTime, bool _isWeeknd)
        {
            this.Date = _date;
            this.Name = _name;
            this.Type = _type;
            this.InTime = _InTime;
            this.OutTime = _OutTime;
            this.IsWeekend = _isWeeknd;
            this.Completed = true;
        }
        public Visitor(string _name, GroupType _type, DateTime _date, DateTime _InTime, bool _isWeeknd)
        {
            this.Date = _date;
            this.Name = _name;
            this.Type = _type;
            this.InTime = _InTime;
            this.IsWeekend = _isWeeknd;
            this.Completed = false;
        }
        public string[] getValues(){
            string[] ret = { this.Name,((GroupType)this.Type).AsString(EnumFormat.Description),    IsWeekend.ToString(), Completed.ToString(), InTime.ToShortTimeString(), OutTime.ToShortTimeString(), Date.ToShortDateString()};
            return ret;
        }
    }
}
