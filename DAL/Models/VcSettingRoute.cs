using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_SETTING_ROUTE")]
public partial class VcSettingRoute
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("ROUTE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string RouteCode { get; set; }

    [Required]
    [Column("WP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string WpCode { get; set; }

    [Required]
    [Column("NODE")]
    [StringLength(1000)]
    public string Node { get; set; }

    [Column("TIME_WORK")]
    public DateTime? TimeWork { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("ORDER")]
    public int? Order { get; set; }

    [Column("TIME_PLAN")]
    public DateTime? TimePlan { get; set; }

    [Column("CURRENT_STATUS")]
    [StringLength(50)]
    public string CurrentStatus { get; set; }

    [Column("PROPORTION", TypeName = "decimal(18, 1)")]
    public decimal? Proportion { get; set; }

    [Column("TOTAL_CAN_IMP", TypeName = "decimal(18, 1)")]
    public decimal? TotalCanImp { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

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
