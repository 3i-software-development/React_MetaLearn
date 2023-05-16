using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_COMMON_SETTING")]
public partial class RmCommonSetting
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("VALUE")]
    [StringLength(255)]
    public string Value { get; set; }

    [Column("GROUP")]
    [StringLength(50)]
    public string Group { get; set; }

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
}
