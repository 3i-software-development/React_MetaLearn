using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_OS_BOARD")]
public partial class WorkOsBoard
{
    [Key]
    [Column("BOARD_ID")]
    public int BoardId { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string BoardCode { get; set; }

    [Column("BOARD_NAME")]
    [StringLength(255)]
    public string BoardName { get; set; }

    [Column("TEAM_CODE")]
    [StringLength(255)]
    public string TeamCode { get; set; }

    [Column("AVATAR")]
    [StringLength(255)]
    public string Avatar { get; set; }

    [Column("VISIBILITY")]
    [StringLength(255)]
    public string Visibility { get; set; }

    [Column("BACKGROUND_COLOR")]
    [StringLength(255)]
    public string BackgroundColor { get; set; }

    [Column("BACKGROUND_IMAGE")]
    [StringLength(255)]
    public string BackgroundImage { get; set; }

    [Column("BOARD_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string BoardType { get; set; }

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

    [Column("UPDATE_BY")]
    [StringLength(50)]
    public string UpdateBy { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    public string Branch { get; set; }

    [Column("DEPARTMENT")]
    [StringLength(255)]
    public string Department { get; set; }
}
