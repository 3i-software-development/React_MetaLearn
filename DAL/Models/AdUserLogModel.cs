using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class AdUserLogModel
    {
        public int Id { get; set; }
        public short? LogType { get; set; }
        public string UserIp { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }
        public string FullName { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class AdUserLogSearch
    {
        public int? UserId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}
