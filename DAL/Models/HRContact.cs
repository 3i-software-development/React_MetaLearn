using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HR_CONTACT")]
public partial class HrContact
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Created_Time")]
    public DateTime? CreatedTime { get; set; }

    [Column("Updated_Time")]
    public DateTime? UpdatedTime { get; set; }

    [StringLength(250)]
    public string Address { get; set; }

    [StringLength(250)]
    public string Phone { get; set; }

    [StringLength(250)]
    public string Email { get; set; }

    [StringLength(250)]
    public string Fax { get; set; }

    [StringLength(250)]
    public string Note { get; set; }

    [Column("Employee_Id")]
    public int EmployeeId { get; set; }

    [StringLength(250)]
    public string Relationship { get; set; }

    [StringLength(250)]
    public string Name { get; set; }

    [Column("Created_By")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("Updated_By")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("Job_Name")]
    [StringLength(250)]
    public string JobName { get; set; }

    public DateTime? Birthday { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }
}
