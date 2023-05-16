using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ACTIVITY_ATTR_DATA")]
public partial class ActivityAttrDatum
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ATTR_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AttrCode { get; set; }

    [Column("VALUE")]
    [StringLength(255)]
    public string Value { get; set; }

    [Column("ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ActCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string Description { get; set; }

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

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("WORK_FLOW_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string WorkFlowCode { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    [Column("SESSION_ID")]
    [StringLength(255)]
    public string SessionId { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }
}
