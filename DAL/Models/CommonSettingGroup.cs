using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("COMMON_SETTING_GROUP")]
public partial class CommonSettingGroup
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(50)]
    public string GroupCode { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(50)]
    public string GroupName { get; set; }
}
