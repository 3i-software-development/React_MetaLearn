using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SUB_WORKFLOW_INSTANCE")]
public partial class SubWorkflowInstance
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

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectCode { get; set; }

    [Column("ACT_INST_INITIAL")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActInstInitial { get; set; }

    [Column("IS_MAIN")]
    public bool? IsMain { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
