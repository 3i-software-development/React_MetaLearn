using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsRole
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? Rank { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }
}
