using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HR_WORKFLOWS")]
public partial class HrWorkflow
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Created_Time")]
    public DateTime? CreatedTime { get; set; }

    [Column("Updated_Time")]
    public DateTime? UpdatedTime { get; set; }

    [Column("Working_Process")]
    [StringLength(250)]
    public string WorkingProcess { get; set; }

    [Column("Employee_Id")]
    public int EmployeeId { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    [Column("Name_Job")]
    [StringLength(250)]
    public string NameJob { get; set; }

    [Column("Info_Details")]
    [StringLength(250)]
    public string InfoDetails { get; set; }

    [Column("Created_By")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("Updated_By")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }
}
