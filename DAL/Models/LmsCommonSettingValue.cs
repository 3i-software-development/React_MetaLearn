using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("lms_common_setting_value")]
public partial class LmsCommonSettingValue
{
    [Column("id")]
    public int Id { get; set; }

    [Column("attr_code")]
    [StringLength(255)]
    public string AttrCode { get; set; }

    [Column("attr_value")]
    [StringLength(255)]
    public string AttrValue { get; set; }

    [Column("unit")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("table_name")]
    [StringLength(255)]
    public string TableName { get; set; }

    [Column("object_code")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("created_by")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("created_time", TypeName = "datetime")]
    public DateTime? CreatedTime { get; set; }

    [Column("updated_by")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("updated_time", TypeName = "datetime")]
    public DateTime? UpdatedTime { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }
}
