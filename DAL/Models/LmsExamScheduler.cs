using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_EXAM_SCHEDULER")]
public partial class LmsExamScheduler
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("EXAM_CODE")]
    [StringLength(255)]
    public string ExamCode { get; set; }

    [Column("LMS_TASK_CODE")]
    [StringLength(255)]
    public string LmsTaskCode { get; set; }

    [Column("START_DATE")]
    public DateTime? StartDate { get; set; }

    [Column("END_DATE")]
    public DateTime? EndDate { get; set; }

    [Column("LIST_USER_APPROVED")]
    public string ListUserApproved { get; set; }

    [Column("JSON_STATUS")]
    public string JsonStatus { get; set; }

    [Column("BACKGROUND_COLOR")]
    [StringLength(255)]
    public string BackgroundColor { get; set; }

    [Column("BACKGROUND_IMAGE")]
    [StringLength(255)]
    public string BackgroundImage { get; set; }

    [Column("JSON_REF")]
    public string JsonRef { get; set; }

    [Column("LOCATION")]
    [StringLength(255)]
    public string Location { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string Description { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }
}
