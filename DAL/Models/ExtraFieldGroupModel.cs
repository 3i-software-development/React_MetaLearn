using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public partial class ExtraFieldGroupModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }
    public class ExtraFieldGroupSearch
    {
        // int Id { get; set; }
        public string Name { get; set; }
        // string Value { get; set; }
        public int pageNo { get; set; }
        public int pageSize { get; set; }
        //  int TotalRow { get; set; }
    }
}
