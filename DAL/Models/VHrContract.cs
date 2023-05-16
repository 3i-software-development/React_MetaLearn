using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VHrContract
{
    [Column("EMPLOYEE_CODE")]
    public int EmployeeCode { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }
}
