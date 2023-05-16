using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ITEM_PLAN_JOBCARD")]
public partial class ItemPlanJobcard
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(255)]
    public string ItemCode { get; set; }

    [Column("JOBCARD_CODE")]
    [StringLength(255)]
    public string JobcardCode { get; set; }

    [Column("WEIGHT", TypeName = "decimal(18, 0)")]
    public decimal? Weight { get; set; }

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
    public bool? IsDeleted { get; set; }
}
