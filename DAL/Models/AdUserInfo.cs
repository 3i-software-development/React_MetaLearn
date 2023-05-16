using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AdUserInfo
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public bool? Gender { get; set; }

    public DateTime? Birthday { get; set; }

    public string Address { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDelete { get; set; }

    public string HomePhone { get; set; }

    public string MobilePhone { get; set; }
}
