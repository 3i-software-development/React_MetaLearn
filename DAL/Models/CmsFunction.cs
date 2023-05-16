using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsFunction
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Flag { get; set; }

    public string Language { get; set; }
}
