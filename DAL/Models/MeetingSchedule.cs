using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MEETING_SCHEDULE")]
public partial class MeetingSchedule
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("COMMENT")]
    [StringLength(255)]
    public string Comment { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("ACCOUNT_ZOOM")]
    [StringLength(255)]
    [Unicode(false)]
    public string AccountZoom { get; set; }

    [Column("LIST_USER_APPROVED")]
    public string ListUserApproved { get; set; }

    [Column("JSON_STATUS")]
    public string JsonStatus { get; set; }

    [Column("BACKGROUND_COLOR")]
    [StringLength(255)]
    public string BackgroundColor { get; set; }

    [Column("BACKGROUND_IMAGE")]
    [StringLength(255)]
    public string BackgroundImage { get; set; }

    [Column("JSON_REF")]
    public string JsonRef { get; set; }

    [Column("MEETING_ID")]
    public int? MeetingId { get; set; }
}
