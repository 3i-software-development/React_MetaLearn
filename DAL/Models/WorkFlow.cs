using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_FLOW")]
public partial class WorkFlow
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WF_CODE")]
    [StringLength(255)]
    public string WfCode { get; set; }

    [Column("WF_NAME")]
    [StringLength(255)]
    public string WfName { get; set; }

    [Column("WF_NOTE")]
    [StringLength(1000)]
    public string WfNote { get; set; }

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

    [Column("WF_GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfGroup { get; set; }

    [Column("WF_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfType { get; set; }

    [Column("IS_PUBLIC")]
    public bool? IsPublic { get; set; }

    [Column("PUBLIC_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string PublicBy { get; set; }

    [Column("PUBLIC_TIME")]
    public DateTime? PublicTime { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectType { get; set; }

    [Column("USER_LIST")]
    public string UserList { get; set; }
}
