using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PARAM_4_WARNING")]
public partial class Param4Warning
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("AET_TYPE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AetType { get; set; }

    [Column("CAT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CatCode { get; set; }

    [Column("TOTAL", TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }

    [Column("FROM_TIME")]
    public DateTime? FromTime { get; set; }

    [Column("TO_TIME")]
    public DateTime? ToTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
