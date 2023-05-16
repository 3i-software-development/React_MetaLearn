using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORKFLOW_ACTIVITY")]
public partial class WorkflowActivity
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

    [Column("PRIORITY")]
    [StringLength(100)]
    [Unicode(false)]
    public string Priority { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("UNIT_TIME")]
    [StringLength(100)]
    [Unicode(false)]
    public string UnitTime { get; set; }

    [Column("LIMIT_TIME")]
    [StringLength(100)]
    [Unicode(false)]
    public string LimitTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    [Unicode(false)]
    public string Branch { get; set; }

    [Column("DEPARTMENT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Department { get; set; }
}
