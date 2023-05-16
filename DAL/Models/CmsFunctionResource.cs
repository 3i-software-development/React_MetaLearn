using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsFunctionResource
{
    public int Id { get; set; }

    public int? FunctionId { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Status { get; set; }
}
