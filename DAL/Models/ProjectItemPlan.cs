using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_ITEM_PLAN")]
public partial class ProjectItemPlan
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(255)]
    public string ItemCode { get; set; }

    [Column("ITEM_NAME")]
    [StringLength(255)]
    public string ItemName { get; set; }

    [Column("ITEM_LEVEL")]
    [StringLength(255)]
    public string ItemLevel { get; set; }

    [Column("ITEM_WEIGHT", TypeName = "decimal(18, 0)")]
    public decimal? ItemWeight { get; set; }

    [Column("ITEM_PARENT")]
    [StringLength(255)]
    public string ItemParent { get; set; }

    [Column("DURATION_TIME")]
    [StringLength(255)]
    public string DurationTime { get; set; }

    [Column("DURATION_UNIT")]
    [StringLength(255)]
    public string DurationUnit { get; set; }

    [Column("COST")]
    [StringLength(255)]
    public string Cost { get; set; }

    [Column("COST_UNIT")]
    [StringLength(255)]
    public string CostUnit { get; set; }

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

    [Column("PROJECT_CODE")]
    [StringLength(255)]
    public string ProjectCode { get; set; }
}
