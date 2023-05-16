using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SALARY_TABLE_ALLOWANCE")]
public partial class SalaryTableAllowance
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ALLOWANCE_CODE")]
    [StringLength(255)]
    public string AllowanceCode { get; set; }

    [Column("CODE_TBL_SALARY")]
    [StringLength(255)]
    public string CodeTblSalary { get; set; }

    [Column("VALUE", TypeName = "decimal(14, 0)")]
    public decimal? Value { get; set; }

    [Column("MONTH")]
    public DateTime? Month { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("EMPLOYEE_CODE")]
    [StringLength(255)]
    public string EmployeeCode { get; set; }
}
