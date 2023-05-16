using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HR_ADDRESS")]
public partial class HrAddress
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Created_Time")]
    public DateTime? CreatedTime { get; set; }

    [Column("Start_Time")]
    public DateTime? StartTime { get; set; }

    [Column("End_Time")]
    public DateTime? EndTime { get; set; }

    [Column("Updated_Time")]
    public DateTime? UpdatedTime { get; set; }

    [Column("Now_Address")]
    [StringLength(250)]
    public string NowAddress { get; set; }

    [StringLength(250)]
    public string Phone { get; set; }

    [Column("Permanent_Address")]
    [StringLength(250)]
    public string PermanentAddress { get; set; }

    [Column("Employee_Id")]
    public int EmployeeId { get; set; }

    [Column("Created_By")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("Updated_By")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }
}
