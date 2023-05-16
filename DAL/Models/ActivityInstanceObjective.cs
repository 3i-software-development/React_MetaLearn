using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ACTIVITY_INSTANCE_OBJECTIVE")]
public partial class ActivityInstanceObjective
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTIVITY_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityInstCode { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectType { get; set; }

    [Column("OBJECT_INST")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectInst { get; set; }

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
}
