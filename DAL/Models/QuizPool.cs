using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("QUIZ_POOL")]
[Index("Code", Name = "IX_QUIZ_POOL", IsUnique = true)]
[Index("IsDeleted", Name = "QUIZ_ATTR_INDEX")]
public partial class QuizPool
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(100)]
    public string Code { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("CONTENT")]
    public string Content { get; set; }

    [Column("CATEGORY")]
    public int? Category { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("LECTURE_RELATIVE")]
    public string LectureRelative { get; set; }

    [Column("LEVEL")]
    [StringLength(255)]
    public string Level { get; set; }

    [Column("LECTURE_CODE")]
    [StringLength(255)]
    public string LectureCode { get; set; }

    [Column("DURATION")]
    public int? Duration { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("JSON_REF")]
    public string JsonRef { get; set; }

    [Column("QUESTION_MEDIA")]
    public string QuestionMedia { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("SHARE")]
    public string Share { get; set; }

    [Column("SOLVE")]
    public string Solve { get; set; }

    [Column("RATING_LOG")]
    public string RatingLog { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("IS_TUTOR888")]
    public bool? IsTutor888 { get; set; }

    [Column("LATEX_IN_QUIZ")]
    public string LatexInQuiz { get; set; }

    [Column("RATING", TypeName = "decimal(18, 0)")]
    public decimal? Rating { get; set; }

    [Column("JSON_CANVAS")]
    public string JsonCanvas { get; set; }

    [Column("HASH_TAG")]
    [StringLength(1000)]
    public string HashTag { get; set; }
}
