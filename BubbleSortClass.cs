using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recreation_center
{
    /*
     * The weekinfo class helps to sort the visitor data for the weekly report
     * The Name contains the name of the day of the week e.g. Sunday, Monday etc.
     */
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


        /*
         * THe bubble sort sorts a list of WeekInfo 
         * It takes another argument cmp which decides which day is greator 
         */
        public static List<WeekInfo> BubbleSort(List<WeekInfo>  days, Comparator cmp)
        {
            for(int i = days.Count -1; i > 0 ; i--)
            {
                for(int j = 0; j <= i -1; j++)
                {
                    if(cmp(days[j], days[j + 1]))
                    {
                        //Swap
                        WeekInfo tmp = days[j];
                        days[j] = days[j + 1];
                        days[j + 1] = tmp;
                    }
                }
            }
            return days;
        }

        // tells if a's totalIncomde is greator than b's totalIncome
        public static bool CompareIncome(WeekInfo a,WeekInfo b)
        {
            return a.TotalIncome > b.TotalIncome;
        }

        // tells if a's number Of visitor is greator than b's Number of visitor
        public static bool CompareNumOfVisitors(WeekInfo a,WeekInfo b)
        {
            return a.NumOfVisitors > b.NumOfVisitors;
        }

    }
}
