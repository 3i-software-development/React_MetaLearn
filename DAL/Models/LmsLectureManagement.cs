using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LMS_LECTURE_MANAGEMENT")]
public partial class LmsLectureManagement
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LECT_CODE")]
    [StringLength(255)]
    public string LectCode { get; set; }

    [Column("LECT_NAME")]
    [StringLength(255)]
    public string LectName { get; set; }

    [Column("LECT_DESCRIPTION")]
    public string LectDescription { get; set; }

    [Column("DURATION")]
    public int? Duration { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("VIDEO_PRESENT")]
    [StringLength(255)]
    public string VideoPresent { get; set; }

    [Column("VIDEOS_DURATION")]
    public string VideosDuration { get; set; }

    [Column("SHARE")]
    public string Share { get; set; }

    [Column("LEVEL")]
    [StringLength(255)]
    public string Level { get; set; }

    [Column("RATING")]
    public string Rating { get; set; }

    [Column("IS_INTERACTIVE")]
    public bool? IsInteractive { get; set; }

    [Column("INTERACTIVE_FILE_PATH")]
    [StringLength(1000)]
    public string InteractiveFilePath { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("JSON_TUTOR888")]
    public string JsonTutor888 { get; set; }

    [Column("IS_TUTOR888")]
    public bool? IsTutor888 { get; set; }

    [Column("ANSWER_TUTOR888")]
    public string AnswerTutor888 { get; set; }

    [Column("AVATAR")]
    public string Avatar { get; set; }

    [Column("LIST_ATTACHMENT")]
    public string ListAttachment { get; set; }

    [Column("LIST_QUESTION")]
    public string ListQuestion { get; set; }

    [Column("COURSE_CODE")]
    [StringLength(255)]
    public string CourseCode { get; set; }

    [Column("LIST_VIDEO")]
    public string ListVideo { get; set; }

    [Column("LIST_JSON_CANVAS")]
    public string ListJsonCanvas { get; set; }
}
