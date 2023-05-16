using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORKFLOW_ACTIVITY_ROLE")]
public partial class WorkflowActivityRole
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WORK_FLOW_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string WorkFlowCode { get; set; }

    [Column("ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ActCode { get; set; }

    [Column("BRANCH_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string BranchCode { get; set; }

    [Column("DEPART_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string DepartCode { get; set; }

    [Column("ROLE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Role { get; set; }

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

    [Column("WORK_FLOW_PROPERTY")]
    [StringLength(255)]
    public string WorkFlowProperty { get; set; }
}
