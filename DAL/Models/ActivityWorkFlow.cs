using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ACTIVITY_WORKFLOW")]
public partial class ActivityWorkflow
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACT_CODE")]
    [StringLength(255)]
    public string ActCode { get; set; }

    [Column("ACT_NAME")]
    [StringLength(255)]
    public string ActName { get; set; }

    [Column("ACT_PARENT")]
    [StringLength(255)]
    public string ActParent { get; set; }

    [Column("ACT_NOTED")]
    [StringLength(1000)]
    public string ActNoted { get; set; }

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

    [Column("ACT_ATTRIBUTE_GRAPH")]
    public string ActAttributeGraph { get; set; }

    [Column("ACT_STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActStatus { get; set; }
}
