using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_PRACTICE_TEST_DETAIL")]
public partial class LmsPracticeTestDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("QUEST_CODE")]
    [StringLength(255)]
    public string QuestCode { get; set; }

    [Column("MARK")]
    public int? Mark { get; set; }

    [Column("ORDER")]
    public int? Order { get; set; }

    [Column("DURATION")]
    public int? Duration { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("PRACTICE_TEST_CODE")]
    [StringLength(255)]
    public string PracticeTestCode { get; set; }

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
}
