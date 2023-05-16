using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_QUIZ_POOL_REFERENCE")]
public partial class LmsQuizPoolReference
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("QUIZ_CODE")]
    [StringLength(100)]
    public string QuizCode { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(100)]
    public string SubjectCode { get; set; }

    [Column("CLASS_CODE")]
    [StringLength(255)]
    public string ClassCode { get; set; }

    [Column("REF_CONTENT")]
    public string RefContent { get; set; }

    [Column("USER_CREATE_REF")]
    [StringLength(255)]
    [Unicode(false)]
    public string UserCreateRef { get; set; }

    [Column("IS_NEWS")]
    public bool? IsNews { get; set; }

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

    [Column("REF_PARENT")]
    public int? RefParent { get; set; }

    [Column("LIKE")]
    public int? Like { get; set; }

    [Column("DISLIKE")]
    public int? Dislike { get; set; }

    [Column("LIKE_LOG")]
    public string LikeLog { get; set; }

    [Column("JSON_CANVAS")]
    public string JsonCanvas { get; set; }
}
