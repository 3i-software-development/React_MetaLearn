using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AdGroup
{
    public int Id { get; set; }

    public string GroupName { get; set; }

    public int? GroupParent { get; set; }

    public string Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsActive { get; set; }
}
