using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recreation_center
{
    public class WeekInfo
    {
        public string Name { get; set; } 
        public int    NumOfVisitors{ get; set; }
        public double TotalIncome{ get; set; }

        public WeekInfo(string name, int numOfVisitors, double totalIncome)
        {
            Name = name;
            NumOfVisitors = numOfVisitors;
            TotalIncome = totalIncome;
        }
    }
    public class BubbleSortClass

    {
        public delegate bool Comparator(WeekInfo a,WeekInfo b);


        public static List<WeekInfo> BubbleSort(List<WeekInfo>  days, Comparator cmp)
        {
            for(int i = days.Count -1; i > 0 ; i--)
            {
                for(int j = 0; j <= i -1; j++)
                {
                    if(cmp(days[j], days[j + 1]))
                    {
                        WeekInfo tmp = days[j];
                        days[j] = days[j + 1];
                        days[j + 1] = tmp;
                    }
                }
            }
            return days;
        }

        public static bool CompareIncome(WeekInfo a,WeekInfo b)
        {
            return a.TotalIncome > b.TotalIncome;
        }

        public static bool CompareNumOfVisitors(WeekInfo a,WeekInfo b)
        {
            return a.NumOfVisitors > b.NumOfVisitors;
        }

    }
}
