using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("WF_ACTIVITY_OBJECT_PROCESSING")]
public partial class WfActivityObjectProcessing
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACT_INST_CODE")]
    [StringLength(255)]
    public string ActInstCode { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("OBJECT_INST")]
    [StringLength(255)]
    public string ObjectInst { get; set; }

    [Column("BESHARE")]
    public bool? Beshare { get; set; }

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

    [Column("OBJ_ENTRY")]
    public bool? ObjEntry { get; set; }

    [Column("WF_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfInstCode { get; set; }

    [Column("IS_LEADER")]
    public bool? IsLeader { get; set; }
}
