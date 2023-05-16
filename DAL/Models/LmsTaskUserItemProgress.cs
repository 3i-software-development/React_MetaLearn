using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LMS_TASK_USER_ITEM_PROGRESS")]
public partial class LmsTaskUserItemProgress
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(255)]
    public string ItemCode { get; set; }

    [Column("TRAINING_TYPE")]
    [StringLength(255)]
    public string TrainingType { get; set; }

    [Column("ITEM_TITLE")]
    public string ItemTitle { get; set; }

    [Column("LMS_TASK_CODE")]
    [StringLength(255)]
    public string LmsTaskCode { get; set; }

    [Column("USER")]
    [StringLength(255)]
    public string User { get; set; }

    [Column("PROGRESS_AUTO", TypeName = "decimal(18, 0)")]
    public decimal? ProgressAuto { get; set; }

    [Column("TEACHER_APPROVED", TypeName = "decimal(18, 0)")]
    public decimal? TeacherApproved { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }
}
