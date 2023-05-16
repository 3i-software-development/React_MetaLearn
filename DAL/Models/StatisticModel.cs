using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class StatisticModel
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public DateTime? VisitTime { get; set; }
        public string VisitIp { get; set; }
        public string UrlRef { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class StatisticCount
    {
        public StatisticCount()
        {
            CountOnline = 0;
            CountToday = 0;
            CountYesterday = 0;
            CountWeek = 0;
            CountWeek = 0;
            CountMonth = 0;
            CountTotal = 0;
        }

        public int CountOnline { get; set; }
        public int CountToday { get; set; }
        public int CountYesterday { get; set; }
        public int CountWeek { get; set; }
        public int CountMonth { get; set; }
        public int CountTotal { get; set; }
    }

    public class StatisticVisit
    {
        public static StatisticCount StatisticCount { get; set; }
        //public static List<StatisticModel> ListStatistic { get; set; }
    }

}
