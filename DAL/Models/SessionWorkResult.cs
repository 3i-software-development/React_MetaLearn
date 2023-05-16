using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SESSION_WORK_RESULT")]
public partial class SessionWorkResult
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WORK_SESSION")]
    [StringLength(255)]
    public string WorkSession { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("PROGRESS_FROM_STAFF", TypeName = "decimal(18, 0)")]
    public decimal? ProgressFromStaff { get; set; }

    [Column("PROGRESS_FROM_LEADER", TypeName = "decimal(18, 0)")]
    public decimal? ProgressFromLeader { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("CHK_LIST_CODE")]
    [StringLength(255)]
    public string ChkListCode { get; set; }

    [Column("NOTE_FROM_LEADER")]
    public string NoteFromLeader { get; set; }

    [Column("SHIFT_CODE")]
    [StringLength(255)]
    public string ShiftCode { get; set; }

    [Column("USER_ASSESSOR")]
    [StringLength(255)]
    public string UserAssessor { get; set; }

    [Column("APPROVE_TIME")]
    public DateTime? ApproveTime { get; set; }

    [Column("ITEM_WORK_LIST")]
    [StringLength(255)]
    public string ItemWorkList { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("LIST_SUB_ITEM")]
    public string ListSubItem { get; set; }

    [Column("GOOGLE_MAP")]
    [StringLength(1000)]
    public string GoogleMap { get; set; }

    [Column("ADDRESS")]
    [StringLength(1000)]
    public string Address { get; set; }

    [Column("LOG_APPROVE")]
    public string LogApprove { get; set; }
}
