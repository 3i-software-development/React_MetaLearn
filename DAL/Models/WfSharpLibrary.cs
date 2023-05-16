using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("WF_SHARP_LIBRARY")]
public partial class WfSharpLibrary
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SHARP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string SharpCode { get; set; }

    [Column("SHARP_NAME")]
    [StringLength(255)]
    public string SharpName { get; set; }

    [Column("SHARP_DATA")]
    public string SharpData { get; set; }

    [Column("SHARP_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string SharpType { get; set; }

    [Column("SHARP_DESC")]
    [StringLength(255)]
    [Unicode(false)]
    public string SharpDesc { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("SHARP_PATH")]
    [StringLength(255)]
    [Unicode(false)]
    public string SharpPath { get; set; }
}
