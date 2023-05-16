using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AdUser
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsActive { get; set; }

    public string Password { get; set; }

    public string PassSalt { get; set; }

    public DateTime? ResetDate { get; set; }

    public int? ResetCount { get; set; }

    public int? RoleId { get; set; }
}
