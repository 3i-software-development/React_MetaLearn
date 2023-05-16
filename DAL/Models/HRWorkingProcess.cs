using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("HR_WORKING_PROCESS")]
public partial class HrWorkingProcess
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Created_Time")]
    public DateTime? CreatedTime { get; set; }

    [Column("Updated_Time")]
    public DateTime? UpdatedTime { get; set; }

    [Column("Wage_Level")]
    [StringLength(250)]
    public string WageLevel { get; set; }

    [Column("End_Date")]
    public DateTime? EndDate { get; set; }

    [Column("Salary_Ratio")]
    public double? SalaryRatio { get; set; }

    [Column("Employee_Id")]
    public int EmployeeId { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    [Column("Start_Time")]
    public DateTime? StartTime { get; set; }

    [Column("Created_By")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("Updated_By")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }
}
