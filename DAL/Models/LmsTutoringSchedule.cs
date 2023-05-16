using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_TUTORING_SCHEDULE")]
public partial class LmsTutoringSchedule
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("SESSION_CODE")]
    [StringLength(255)]
    public string SessionCode { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("JSON_STATUS")]
    public string JsonStatus { get; set; }

    [Column("LIST_USER_APPROVED")]
    public string ListUserApproved { get; set; }

    [Column("BACKGROUND_COLOR")]
    [StringLength(255)]
    public string BackgroundColor { get; set; }

    [Column("BACKGROUND_IMAGE")]
    [StringLength(255)]
    public string BackgroundImage { get; set; }

    [Column("TEACHER")]
    [StringLength(255)]
    public string Teacher { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("COURSE_CODE")]
    [StringLength(255)]
    public string CourseCode { get; set; }

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

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("ACCOUNT_ZOOM")]
    [StringLength(255)]
    [Unicode(false)]
    public string AccountZoom { get; set; }

    [Column("LESSON_DOC")]
    public string LessonDoc { get; set; }

    [Column("IS_POPUP_ALLOWED")]
    public bool? IsPopupAllowed { get; set; }

    [Column("MEETING_ID")]
    public int? MeetingId { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("PATH_NOTEPAD")]
    [StringLength(1000)]
    public string PathNotepad { get; set; }

    [Column("JSON_CANVAS")]
    public string JsonCanvas { get; set; }

    [Column("CLASS_CODE")]
    [StringLength(255)]
    public string ClassCode { get; set; }
}
