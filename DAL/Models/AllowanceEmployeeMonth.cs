using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ALLOWANCE_EMPLOYEE_MONTH")]
public partial class AllowanceEmployeeMonth
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EMPLOYEE_ID")]
    [StringLength(100)]
    [Unicode(false)]
    public string EmployeeId { get; set; }

    [Column("EMPLOYEE_NAME")]
    [StringLength(255)]
    public string EmployeeName { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DepartmentCode { get; set; }

    [Column("DEPARTMENT_NAME")]
    [StringLength(255)]
    public string DepartmentName { get; set; }

    [Column("MONTH", TypeName = "date")]
    public DateTime Month { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? C { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? D { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? E { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? F { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? G { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? H { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? I { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? J { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? K { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? L { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? M { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? N { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? O { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? P { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Q { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? R { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? S { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? T { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? U { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? V { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? W { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? X { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Y { get; set; }

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
}
