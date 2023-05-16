using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DECISION_MOVEMENT_DETAIL")]
public partial class DecisionMovementDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EMPLOYEES_CODE")]
    [StringLength(255)]
    public string EmployeesCode { get; set; }

    [Column("DECISION_NUM")]
    [StringLength(255)]
    public string DecisionNum { get; set; }

    [Column("NEW_DEPART_CODE")]
    [StringLength(255)]
    public string NewDepartCode { get; set; }

    [Column("NEW_ROLE")]
    [StringLength(255)]
    public string NewRole { get; set; }

    [Column("PAY_SCALE_CODE")]
    [StringLength(255)]
    public string PayScaleCode { get; set; }

    [Column("PAY_RANGES")]
    [StringLength(38)]
    public string PayRanges { get; set; }

    [Column("SALARY", TypeName = "decimal(38, 2)")]
    public decimal? Salary { get; set; }

    [Column("REASON_MOVEMENT")]
    [StringLength(255)]
    public string ReasonMovement { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("FROM_TIME")]
    public DateTime? FromTime { get; set; }

    [Column("TO_TIME")]
    public DateTime? ToTime { get; set; }
}
