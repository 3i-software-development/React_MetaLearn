using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("TRANSITION")]
public partial class Transition
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TRS_CODE")]
    [StringLength(255)]
    public string TrsCode { get; set; }

    [Column("TRS_TITLE")]
    [StringLength(255)]
    public string TrsTitle { get; set; }

    [Column("TRS_TYPE")]
    [StringLength(255)]
    public string TrsType { get; set; }

    [Column("TRS_NOTED")]
    [StringLength(255)]
    public string TrsNoted { get; set; }

    [Column("TRS_ATTR_GRAPH")]
    public string TrsAttrGraph { get; set; }

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

    [Column("TRS_PARENT")]
    [StringLength(255)]
    public string TrsParent { get; set; }
}
