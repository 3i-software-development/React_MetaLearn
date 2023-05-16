using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VSubjectHierachy
{
    [Column("ID")]
    public int? Id { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("SUBJECT_NAME")]
    [StringLength(255)]
    public string SubjectName { get; set; }

    [Column("SUBJECT_DESCRIPTION")]
    public string SubjectDescription { get; set; }

    [Column("DURATION")]
    public int? Duration { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("IMAGE_COVER")]
    [StringLength(255)]
    public string ImageCover { get; set; }

    [Column("VIDEO_PRESENT")]
    [StringLength(255)]
    public string VideoPresent { get; set; }

    [Column("FILE_BASE")]
    public string FileBase { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("TEACHER")]
    public string Teacher { get; set; }

    [Column("AUTHOR")]
    [StringLength(1000)]
    public string Author { get; set; }

    [Column("PARENT")]
    public int? Parent { get; set; }

    [Column("EDMS_CAT_CODE")]
    [StringLength(255)]
    public string EdmsCatCode { get; set; }

    [Column("ICON_FA")]
    [StringLength(255)]
    public string IconFa { get; set; }

    [Column("IS_TUTOR888")]
    public bool? IsTutor888 { get; set; }

    [Column("ID888")]
    public int? Id888 { get; set; }

    [Column("HIERACHY_LEVEL")]
    public int? HierachyLevel { get; set; }

    [Column("HIERACHY_DESC")]
    public string HierachyDesc { get; set; }

    [Column("HIERACHY_CODE")]
    public string HierachyCode { get; set; }

    [Column("COUNT_QUIZ")]
    public int? CountQuiz { get; set; }

    [Column("COUNT_EXAM")]
    public int? CountExam { get; set; }
}
