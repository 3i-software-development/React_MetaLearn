using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_extra_fields_value")]
public partial class CmsExtraFieldsValue
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    /// <summary>
    /// Tiêu đề
    /// </summary>
    [Column("field_value")]
    public string FieldValue { get; set; }

    /// <summary>
    /// Vị trí
    /// </summary>
    [Column("field_group")]
    public int? FieldGroup { get; set; }

    /// <summary>
    /// Thứ tự
    /// </summary>
    [Column("ordering")]
    public int? Ordering { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("modified_by")]
    public int? ModifiedBy { get; set; }

    [Column("modified_date", TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column("trash")]
    public bool? Trash { get; set; }

    [Column("publish")]
    public bool? Publish { get; set; }

    [Column("date_post", TypeName = "datetime")]
    public DateTime? DatePost { get; set; }
}
