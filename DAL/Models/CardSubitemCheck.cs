using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CARD_SUBITEM_CHECK")]
public partial class CardSubitemCheck
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CHK_LIST_CODE")]
    [StringLength(255)]
    public string ChkListCode { get; set; }

    [Column("TITLE")]
    public string Title { get; set; }

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

    [Column("APPROVE")]
    public bool Approve { get; set; }

    [Column("APPROVER")]
    [StringLength(100)]
    [Unicode(false)]
    public string Approver { get; set; }

    [Column("APPROVED_TIME")]
    public DateTime? ApprovedTime { get; set; }

    [Column("FLAG")]
    public bool Flag { get; set; }
}
