using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CARD_ITEM_CHECK_TRACKING_PROGRESS")]
public partial class CardItemCheckTrackingProgress
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ItemCode { get; set; }

    [Column("COMPLETED")]
    public int Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }
}
