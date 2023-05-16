using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_ATTRIBUTE")]
public partial class ProjectAttribute
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProjectCode { get; set; }

    [Key]
    [Column("ATTR_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AttrCode { get; set; }

    [Column("ATTR_VALUE")]
    [StringLength(255)]
    public string AttrValue { get; set; }

    [Column("ATTR_GROUP")]
    [StringLength(50)]
    [Unicode(false)]
    public string AttrGroup { get; set; }

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
