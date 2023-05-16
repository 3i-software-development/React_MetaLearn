using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("USER_EXAMINATION_RESULT_DETAIL")]
public partial class UserExaminationResultDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SESSION_CODE")]
    [StringLength(255)]
    public string SessionCode { get; set; }

    [Column("QUESTION_CODE")]
    [StringLength(255)]
    public string QuestionCode { get; set; }

    [Column("ANSWER")]
    [StringLength(255)]
    public string Answer { get; set; }

    [Column("GUIDE")]
    [StringLength(255)]
    public string Guide { get; set; }

    [Column("IS_PASS")]
    public bool? IsPass { get; set; }

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
}
