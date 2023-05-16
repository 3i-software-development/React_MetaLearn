using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class FunctionResourceModel
    {
        public int FunctionId { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsCheck { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class FunctionResourceSearch
    {
        public int FunctionId { get; set; }
        //public int? CategoryId { get; set; }
        //public bool? IsCheck { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}
