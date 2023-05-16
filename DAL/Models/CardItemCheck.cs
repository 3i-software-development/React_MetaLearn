using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CARD_ITEM_CHECK")]
public partial class CardItemCheck
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("CHECK_TITLE")]
    public string CheckTitle { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("MEMBER_ID")]
    [StringLength(255)]
    public string MemberId { get; set; }

    [Column("FINISHTIME")]
    public DateTime? Finishtime { get; set; }

    [Column("CHK_LIST_CODE")]
    [StringLength(255)]
    public string ChkListCode { get; set; }

    [Column("PERCENT")]
    public int Percent { get; set; }

    [Column("COMPLETED", TypeName = "decimal(14, 2)")]
    public decimal Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }

    [Column("COST", TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column("DEADLINE")]
    public DateTime? Deadline { get; set; }

    [Column("LOCATION_TEXT")]
    [StringLength(255)]
    public string LocationText { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(255)]
    [Unicode(false)]
    public string LocationGps { get; set; }

    [Column("DEVICE")]
    [StringLength(255)]
    public string Device { get; set; }

    [Column("BEGIN_TIME")]
    public DateTime? BeginTime { get; set; }

    [Column("WEIGHT_NUM", TypeName = "decimal(14, 2)")]
    public decimal WeightNum { get; set; }

    [Column("FLAG")]
    public bool Flag { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("CONSTRAINT")]
    public string Constraint { get; set; }

    [Column("WF_INST_CODE")]
    [StringLength(255)]
    public string WfInstCode { get; set; }

    [Column("ACT_INST_CODE")]
    [StringLength(255)]
    public string ActInstCode { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }
}
