using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ACTIVITY_TRANSITION")]
public partial class ActivityTransition
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WF_CODE")]
    [StringLength(255)]
    public string WfCode { get; set; }

    [Column("ACT_INITIAL")]
    [StringLength(255)]
    public string ActInitial { get; set; }

    [Column("CONDITION")]
    [StringLength(255)]
    public string Condition { get; set; }

    [Column("ACT_DESTINATION")]
    [StringLength(255)]
    public string ActDestination { get; set; }

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
