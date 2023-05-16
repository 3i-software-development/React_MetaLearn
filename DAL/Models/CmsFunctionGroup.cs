using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsFunctionGroup
{
    public int Id { get; set; }

    public int? FunctionId { get; set; }

    public int? GroupId { get; set; }

    public bool? View { get; set; }

    public bool? Add { get; set; }

    public bool? Update { get; set; }

    public bool? Delete { get; set; }

    public bool? Full { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Status { get; set; }
}
