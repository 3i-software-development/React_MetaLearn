using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class TagModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Items { get; set; }
        public bool? Published { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class TagSearch
    {
        public string Name { get; set; }
        public bool? Published { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}
