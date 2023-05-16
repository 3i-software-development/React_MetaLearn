using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PAY_SCALE")]
public partial class PayScale
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PAY_SCALE_CODE")]
    [StringLength(255)]
    public string PayScaleCode { get; set; }

    [Column("PAY_BASE", TypeName = "decimal(38, 0)")]
    public decimal? PayBase { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
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

    [Column("CAREER_CODE")]
    [StringLength(255)]
    public string CareerCode { get; set; }

    [Column("CAREER_TITLE")]
    [StringLength(255)]
    public string CareerTitle { get; set; }

    [Column("CERTIFICATE")]
    [StringLength(255)]
    public string Certificate { get; set; }

    [Column("MAJOR")]
    [StringLength(255)]
    public string Major { get; set; }
}
