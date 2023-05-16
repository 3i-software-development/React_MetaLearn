using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("JC_OBJECT_TYPE")]
public partial class JcObjectType
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_TYPE_CODE")]
    [StringLength(255)]
    public string ObjTypeCode { get; set; }

    [Column("OBJ_TYPE_NAME")]
    [StringLength(255)]
    public string ObjTypeName { get; set; }

    [Column("SCRIPT_SQL")]
    [StringLength(1000)]
    public string ScriptSql { get; set; }

    [Column("SCRIPT_LINQ")]
    [StringLength(1000)]
    public string ScriptLinq { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

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

    [Column("TABLE_NAME")]
    [StringLength(255)]
    public string TableName { get; set; }
}
