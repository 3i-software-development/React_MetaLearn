using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PAY_SHEET")]
public partial class PaySheet
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PAY_GRADES_CODE")]
    [StringLength(255)]
    public string PayGradesCode { get; set; }

    [Column("PAY_GRADES_GROUP")]
    [StringLength(255)]
    public string PayGradesGroup { get; set; }

    [Column("PAY_SCALE")]
    [StringLength(255)]
    public string PayScale { get; set; }

    [Column("PAY_RANGES")]
    public int? PayRanges { get; set; }

    [Column("PAY_COEF", TypeName = "decimal(38, 2)")]
    public decimal? PayCoef { get; set; }

    [Column("BASIC_PAY", TypeName = "decimal(38, 0)")]
    public decimal? BasicPay { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("PAY_GRADES_NAME")]
    [StringLength(255)]
    public string PayGradesName { get; set; }
}
