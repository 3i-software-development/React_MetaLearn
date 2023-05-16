using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EMPLOYEE_STATUS_TRACKING")]
public partial class EmployeeStatusTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EMPLOYEE_CODE")]
    [StringLength(255)]
    public string EmployeeCode { get; set; }

    [Column("STATUS_CODE")]
    [StringLength(255)]
    public string StatusCode { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("OBJECT_RELATIVE")]
    [StringLength(255)]
    public string ObjectRelative { get; set; }
}
