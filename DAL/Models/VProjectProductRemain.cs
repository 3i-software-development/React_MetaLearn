using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VProjectProductRemain
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(255)]
    public string ProductName { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("UNIT_NAME")]
    [StringLength(255)]
    public string UnitName { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    public string ProjectCode { get; set; }

    [Column("PROJECT_TITLE")]
    [StringLength(255)]
    public string ProjectTitle { get; set; }

    [Column("TOTAL_REMAIN", TypeName = "decimal(38, 2)")]
    public decimal? TotalRemain { get; set; }
}
