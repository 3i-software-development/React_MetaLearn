using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_FLOW_RULE")]
public partial class WorkFlowRule
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACT_CODE")]
    [StringLength(255)]
    public string ActCode { get; set; }

    [Column("RULE")]
    [StringLength(255)]
    public string Rule { get; set; }

    [Column("STEP_BACK")]
    [StringLength(255)]
    public string StepBack { get; set; }

    [Column("STEP_FORWARD")]
    [StringLength(255)]
    public string StepForward { get; set; }

    [Column("PRIORITY")]
    public int? Priority { get; set; }

    [Column("FROM_TIME")]
    public DateTime? FromTime { get; set; }

    [Column("TO_TIME")]
    public DateTime? ToTime { get; set; }

    [Column("NOTED")]
    [StringLength(1000)]
    public string Noted { get; set; }

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
    public bool? IsDeleted { get; set; }
}
