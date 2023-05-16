using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("HR_EMPLOYEE_MOBILIZATION")]
public partial class HrEmployeeMobilization
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DECISION_ID")]
    [StringLength(255)]
    public string DecisionId { get; set; }

    [Column("EMPLOYEE_ID")]
    [StringLength(255)]
    public string EmployeeId { get; set; }

    [Column("DEPARTMENT_ID_OLD")]
    [StringLength(255)]
    [Unicode(false)]
    public string DepartmentIdOld { get; set; }

    [Column("ROLE_ID_OLD")]
    [StringLength(255)]
    [Unicode(false)]
    public string RoleIdOld { get; set; }

    [Column("DEPARTMENT_ID_NEW")]
    [StringLength(255)]
    [Unicode(false)]
    public string DepartmentIdNew { get; set; }

    [Column("ROLE_ID_NEW")]
    [StringLength(255)]
    [Unicode(false)]
    public string RoleIdNew { get; set; }

    [Column("WAGE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Wage { get; set; }

    [Column("WAGE_LEVEL")]
    [StringLength(255)]
    [Unicode(false)]
    public string WageLevel { get; set; }

    [Column("REASON")]
    public string Reason { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("FORM_DATE")]
    public DateTime? FormDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }
}
