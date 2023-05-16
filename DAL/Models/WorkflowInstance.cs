using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORKFLOW_INSTANCE")]
public partial class WorkflowInstance
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WF_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfInstCode { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectType { get; set; }

    [Column("OBJECT_INST")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectInst { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("WORKFLOW_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCode { get; set; }

    [Column("DESC")]
    public string Desc { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("USER_MANAGER")]
    public string UserManager { get; set; }

    [Column("IS_LOCK")]
    public bool? IsLock { get; set; }

    [Column("MARK_ACT_CURRENT")]
    [StringLength(255)]
    [Unicode(false)]
    public string MarkActCurrent { get; set; }

    [Column("WF_INST_NAME")]
    [StringLength(255)]
    public string WfInstName { get; set; }

    [Column("WF_GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfGroup { get; set; }

    [Column("ACT_INST_INITIAL")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActInstInitial { get; set; }

    [Column("DATA_ATTR")]
    public string DataAttr { get; set; }

    [Column("WF_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfType { get; set; }

    [Column("WF_DESC")]
    [StringLength(1000)]
    public string WfDesc { get; set; }

    [Column("USER_LIST")]
    public string UserList { get; set; }
}
