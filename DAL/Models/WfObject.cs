using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("WF_OBJECT")]
public partial class WfObject
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WF_OBJ_CODE")]
    [StringLength(255)]
    public string WfObjCode { get; set; }

    [Column("WF_OBJ_NAME")]
    [StringLength(255)]
    public string WfObjName { get; set; }

    [Column("WF_OBJ_TYPE")]
    [StringLength(255)]
    public string WfObjType { get; set; }

    [Column("WF_OBJ_NOTED")]
    [StringLength(1000)]
    public string WfObjNoted { get; set; }

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
