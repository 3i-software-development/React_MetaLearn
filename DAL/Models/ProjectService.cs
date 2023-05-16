using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_SERVICE")]
public partial class ProjectService
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SERVICE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ServiceCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("LEVEL")]
    [StringLength(255)]
    [Unicode(false)]
    public string Level { get; set; }

    [Column("DURATION_TIME")]
    [StringLength(255)]
    [Unicode(false)]
    public string DurationTime { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProjectCode { get; set; }
}
