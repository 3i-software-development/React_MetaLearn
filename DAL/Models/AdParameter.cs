using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("AD_PARAMETER")]
public partial class AdParameter
{
    [Column("PARAMETER_ID", TypeName = "decimal(10, 0)")]
    public decimal ParameterId { get; set; }

    [Required]
    [Column("PARAMETER_CODE")]
    [StringLength(50)]
    public string ParameterCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("PARENT_CODE")]
    [StringLength(50)]
    public string ParentCode { get; set; }

    [Column("VALUE")]
    [StringLength(50)]
    public string Value { get; set; }

    [Column("VALUE2")]
    [StringLength(50)]
    public string Value2 { get; set; }

    [Column("VALUE3")]
    [StringLength(50)]
    public string Value3 { get; set; }

    [Column("VALUE4")]
    [StringLength(50)]
    public string Value4 { get; set; }

    [Column("VALUE5")]
    [StringLength(50)]
    public string Value5 { get; set; }
}
