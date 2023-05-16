using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PLAN_EXCUTE_RECRUITMENT_DETAIL")]
public partial class PlanExcuteRecruitmentDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("RECRUITMENT_CODE")]
    [StringLength(255)]
    public string RecruitmentCode { get; set; }

    [Column("CANDIDATE_CODE")]
    [StringLength(255)]
    public string CandidateCode { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    [Column("RESULT")]
    [StringLength(255)]
    public string Result { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("LIST_FILE_RESULT")]
    [StringLength(255)]
    public string ListFileResult { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

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

    [Column("CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; }
}
