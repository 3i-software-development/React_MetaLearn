using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class StatisticRefModel
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public int StatisticId { get; set; }
        public DateTime? VisitTime { get; set; }
        public string VisitIp { get; set; }
        public string UrlRef { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class StatisticRefSearch
    {
        public string VisitIp { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? FromDate { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}
