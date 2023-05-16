using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_ROMOOC_EXTRAFIELD")]
public partial class RmRomoocExtrafield
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("FIELD_CODE")]
    [StringLength(255)]
    public string FieldCode { get; set; }

    [Column("FIELD_TYPE")]
    [StringLength(255)]
    public string FieldType { get; set; }

    [Column("FIELD_VALUE")]
    [StringLength(255)]
    public string FieldValue { get; set; }

    [Column("FLAG")]
    public int Flag { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }
}
