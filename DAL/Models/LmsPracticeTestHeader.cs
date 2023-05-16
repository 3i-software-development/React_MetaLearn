using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_PRACTICE_TEST_HEADER")]
public partial class LmsPracticeTestHeader
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRACTICE_TEST_CODE")]
    [StringLength(255)]
    public string PracticeTestCode { get; set; }

    [Column("PRACTICE_TEST_TITLE")]
    [StringLength(255)]
    public string PracticeTestTitle { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string Description { get; set; }

    [Column("DURATION")]
    public int? Duration { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("LEVEL")]
    [StringLength(255)]
    public string Level { get; set; }

    [Column("MARK_PASS")]
    public int? MarkPass { get; set; }

    [Column("MARK_TOTAL")]
    public int? MarkTotal { get; set; }

    [Column("NUM_QUIZ")]
    public int? NumQuiz { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("VIEW_RESULT")]
    public bool? ViewResult { get; set; }

    [Column("REWORK")]
    public bool? Rework { get; set; }

    [Column("WORK_SEQUENCE")]
    public bool? WorkSequence { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("IS_PUBLISHED")]
    public bool? IsPublished { get; set; }

    [Column("SHARE")]
    public string Share { get; set; }

    [Column("RATING_LOG")]
    public string RatingLog { get; set; }

    [Column("RATING", TypeName = "decimal(18, 0)")]
    public decimal? Rating { get; set; }

    [Column("FILE_PATH")]
    public string FilePath { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("HASH_TAG")]
    [StringLength(1000)]
    public string HashTag { get; set; }
}
