using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_CUS_SUP")]
public partial class ProjectCusSup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }

    [Column("ROLE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Role { get; set; }

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
    public bool IsDeleted { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(255)]
    public string ProjectCode { get; set; }

    [Column("IS_MAIN")]
    public bool IsMain { get; set; }
}
