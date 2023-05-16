using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PAY_SCALE_DETAIL")]
public partial class PayScaleDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SCALE_CODE")]
    [StringLength(255)]
    public string ScaleCode { get; set; }

    [Column("RANGES")]
    [StringLength(255)]
    public string Ranges { get; set; }

    [Column("COEFF", TypeName = "decimal(38, 2)")]
    public decimal? Coeff { get; set; }

    [Column("SCALE_DT_CODE")]
    [StringLength(255)]
    public string ScaleDtCode { get; set; }

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

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("SALARY", TypeName = "decimal(38, 0)")]
    public decimal? Salary { get; set; }

    [Column("CAREER_CODE")]
    [StringLength(255)]
    public string CareerCode { get; set; }
}
