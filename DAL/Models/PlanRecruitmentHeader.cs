using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PLAN_RECRUITMENT_HEADER")]
public partial class PlanRecruitmentHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PLAN_NUMBER")]
    [StringLength(255)]
    public string PlanNumber { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("PLAN_TYPE")]
    [StringLength(255)]
    public string PlanType { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(255)]
    public string DepartmentCode { get; set; }

    [Column("USER_CREATED")]
    [StringLength(255)]
    public string UserCreated { get; set; }

    [Column("PLAN_DATE")]
    public DateTime? PlanDate { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    public string WorkflowCat { get; set; }

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

    [Column("JSON_DATA")]
    public string JsonData { get; set; }
}
