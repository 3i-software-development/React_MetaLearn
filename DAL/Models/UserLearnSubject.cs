using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("USER_LEARN_SUBJECT")]
public partial class UserLearnSubject
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("LECTURE_CODE")]
    [StringLength(255)]
    public string LectureCode { get; set; }

    [Column("SESSION_CODE")]
    [StringLength(255)]
    public string SessionCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("STOP_TIME")]
    public DateTime? StopTime { get; set; }
}
