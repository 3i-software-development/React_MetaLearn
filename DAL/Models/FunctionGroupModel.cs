using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class FunctionGroupModel
    {
        public int GroupId { get; set; }
        public int? FunctionId { get; set; }
        public string FunctionName { get; set; }
        public bool IsView { get; set; }
        public bool IsAdd { get; set; }
        public bool IsEdit { get; set; }
        public bool IsDelete { get; set; }
        public bool IsFull { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class FunctionGroupSearch
    {
        public int GroupId { get; set; }
        //public int? CategoryId { get; set; }
        //public bool? IsCheck { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

    public class ActionModel
    {
        public int? FunctionId { get; set; }
        public bool View { get; set; }
        public bool Add { get; set; }
        public bool Edit { get; set; }
        public bool Del{ get; set; }
        public bool Full { get; set; }
    }
}
