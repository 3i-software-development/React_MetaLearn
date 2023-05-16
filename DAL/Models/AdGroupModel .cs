using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class AdGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description{ get; set; }
        public int? ParentId { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public int? UserCount { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class AdGroupSearch
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

    public class AdGroupUserModel
    {
        public int UId { get; set; }
        public string GroupName { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }

    }

    public class AdGroupUserSearch
    {
        public int GroupId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}
