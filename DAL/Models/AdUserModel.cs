using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class AdUserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public string PassWord { get; set; }
        public string PassSalt { get; set; }
        public DateTime? ResetDate { get; set; }
        public int? ResetCount { get; set; }
        public string GroupName { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
        public int? GroupId { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? CreatedUserInfo { get; set; }
        public DateTime? ModifiedUserInfo { get; set; }
        public bool? DeleteUserInfo { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public int? RoleId { get; set; }
    }

    public class UserSearch
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? GroupUser { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

    public class UserLogin
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }

    public class DropdownListModel
    {
        public int? Key { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public string Group { get; set; }
    }
}
