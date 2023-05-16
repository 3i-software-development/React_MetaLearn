using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_WORK_PLAN")]
public partial class VcWorkPlan
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("WP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string WpCode { get; set; }

    [Required]
    [Column("USER_NAME")]
    [StringLength(50)]
    public string UserName { get; set; }

    [Column("FROM_DATE")]
    public DateTime FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime ToDate { get; set; }

    [Column("WEEK_NO")]
    public int? WeekNo { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string Description { get; set; }

    [Column("CURRENT_STATUS")]
    [StringLength(50)]
    public string CurrentStatus { get; set; }

    [Column("LEADER_IDEA")]
    [StringLength(500)]
    public string LeaderIdea { get; set; }

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

    [Column("APPROVED_BY")]
    [StringLength(50)]
    public string ApprovedBy { get; set; }

    [Column("APPROVED_TIME")]
    public DateTime? ApprovedTime { get; set; }
}
