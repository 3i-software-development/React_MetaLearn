using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AdUserReset
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Activation { get; set; }

    public string ResetLink { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ExpriedDate { get; set; }

    public bool? IsConfirmed { get; set; }

    /// <summary>
    /// 1. Reset password | 2. Activation
    /// </summary>
    public short? ResetType { get; set; }

    public int? UserId { get; set; }
}
