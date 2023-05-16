using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PAY_DECISION_DETAILS")]
public partial class PayDecisionDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DECISION_NUM")]
    [StringLength(255)]
    public string DecisionNum { get; set; }

    [Column("EMPLOYEE_CODE")]
    [StringLength(255)]
    public string EmployeeCode { get; set; }

    [Column("LABOUR_CONTRACT")]
    [StringLength(255)]
    public string LabourContract { get; set; }

    [Column("PAY_SCALE")]
    [StringLength(255)]
    public string PayScale { get; set; }

    [Column("SALARY", TypeName = "decimal(18, 0)")]
    public decimal? Salary { get; set; }

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

    [Column("CAREER_CODE")]
    [StringLength(255)]
    public string CareerCode { get; set; }

    [Column("CAREER_TITLE")]
    [StringLength(255)]
    public string CareerTitle { get; set; }

    [Column("PAY_RANGE")]
    [StringLength(255)]
    public string PayRange { get; set; }
}
