using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VHighchartProd
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("MONTH")]
    public int? Month { get; set; }

    [Required]
    [Column("NAME")]
    [StringLength(4)]
    public string Name { get; set; }

    [Column("TOTAL", TypeName = "decimal(38, 2)")]
    public decimal? Total { get; set; }
}
