using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_ITEM_SESSION")]
public partial class WorkItemSession
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WORK_SESSION")]
    [StringLength(255)]
    public string WorkSession { get; set; }

    [Column("ITEM_WORK_LIST")]
    [StringLength(255)]
    public string ItemWorkList { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("PROGRESS", TypeName = "decimal(18, 0)")]
    public decimal? Progress { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("SHIFT_CODE")]
    [StringLength(255)]
    public string ShiftCode { get; set; }
}
