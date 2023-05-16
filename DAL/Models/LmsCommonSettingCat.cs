using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("lms_common_setting_cat")]
public partial class LmsCommonSettingCat
{
    [Column("id")]
    public int Id { get; set; }

    [Column("attr_code")]
    [StringLength(255)]
    public string AttrCode { get; set; }

    [Column("attr_name")]
    [StringLength(255)]
    public string AttrName { get; set; }

    [Column("attr_note")]
    [StringLength(255)]
    public string AttrNote { get; set; }

    [Column("group")]
    public int? Group { get; set; }

    [Column("type")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("data_type")]
    [StringLength(255)]
    public string DataType { get; set; }

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

    [Column("order")]
    public int? Order { get; set; }
}
