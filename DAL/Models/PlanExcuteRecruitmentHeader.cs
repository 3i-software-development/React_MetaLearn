using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PLAN_EXCUTE_RECRUITMENT_HEADER")]
public partial class PlanExcuteRecruitmentHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("RECRUITMENT_CODE")]
    [StringLength(255)]
    public string RecruitmentCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("PLAN_NUMBER")]
    [StringLength(255)]
    public string PlanNumber { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("STATUS_LOG")]
    public string StatusLog { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
