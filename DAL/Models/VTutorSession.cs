using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VTutorSession
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

    [Column("MEETING_ID")]
    [StringLength(100)]
    [Unicode(false)]
    public string MeetingId { get; set; }

    [Column("PASSWORD")]
    [StringLength(100)]
    [Unicode(false)]
    public string Password { get; set; }

    [Column("JOIN_URL")]
    [StringLength(1000)]
    public string JoinUrl { get; set; }

    [Column("LIST_USER_APPROVED")]
    public string ListUserApproved { get; set; }

    [Column("TEACHER")]
    [StringLength(255)]
    public string Teacher { get; set; }

    [Column("TEACHER_NAME")]
    [StringLength(256)]
    public string TeacherName { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Required]
    [Column("SUBJECT_NAME")]
    [StringLength(255)]
    public string SubjectName { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("PATH_NOTEPAD")]
    [StringLength(1000)]
    public string PathNotepad { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CLASS_CODE")]
    [StringLength(50)]
    public string ClassCode { get; set; }

    [Column("HOST_CLAIM_CODE")]
    [StringLength(255)]
    public string HostClaimCode { get; set; }
}
