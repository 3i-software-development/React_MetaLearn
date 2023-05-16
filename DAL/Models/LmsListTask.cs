using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_LIST_TASK")]
public partial class LmsListTask
{
    [Column("LIST_ID")]
    public int ListId { get; set; }

    [Required]
    [Column("LIST_CODE")]
    [StringLength(100)]
    public string ListCode { get; set; }

    [Column("LIST_NAME")]
    [StringLength(255)]
    public string ListName { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(100)]
    public string BoardCode { get; set; }

    [Column("ORDER")]
    public int Order { get; set; }

    [Column("AVATAR")]
    [StringLength(255)]
    public string Avatar { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("BACKGROUND")]
    [StringLength(255)]
    public string Background { get; set; }

    [Column("COMPLETED", TypeName = "decimal(14, 2)")]
    public decimal Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }

    [Column("COST", TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column("DEADLINE")]
    public DateTime Deadline { get; set; }

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
    public DateTime BeginTime { get; set; }

    [Column("WEIGHT_NUM", TypeName = "decimal(14, 2)")]
    public decimal WeightNum { get; set; }

    [Column("CREATED_DATE")]
    public DateTime CreatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
