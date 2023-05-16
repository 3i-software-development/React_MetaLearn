using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_ACTIVITY")]
public partial class AssetActivity
{
    [Column("ACT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActCode { get; set; }

    [Column("ACT_TITLE")]
    [StringLength(255)]
    public string ActTitle { get; set; }

    [Column("ACT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ActType { get; set; }

    [Column("ACT_NOTE")]
    public string ActNote { get; set; }

    [Column("ACT_MEMBER")]
    public string ActMember { get; set; }

    [Column("PARENT_CODE")]
    public int? ParentCode { get; set; }

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

    [Key]
    [Column("ACTIVITY_ID")]
    public int ActivityId { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AssetCode { get; set; }
}
