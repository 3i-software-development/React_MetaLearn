using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Rank { get; set; }      
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }

        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class RoleSearch
    {
        public string Name { get; set; }       
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

}
