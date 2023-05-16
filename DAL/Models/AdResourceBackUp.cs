using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_RESOURCE_BACK_UP")]
public partial class AdResourceBackUp
{
    [Key]
    [Column("RESOURCE_CODE")]
    [StringLength(100)]
    public string ResourceCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(2000)]
    public string Description { get; set; }

    [Column("API")]
    [StringLength(255)]
    public string Api { get; set; }

    [Column("PATH")]
    [StringLength(255)]
    public string Path { get; set; }

    [Column("ORD")]
    public int? Ord { get; set; }

    [Column("STATUS")]
    public bool Status { get; set; }

    [Column("PARENT_CODE")]
    [StringLength(100)]
    public string ParentCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("STYLE")]
    [StringLength(10)]
    public string Style { get; set; }

    [Column("SCOPE")]
    public bool Scope { get; set; }

    [Column("RESOURCE_ID")]
    public int ResourceId { get; set; }
}
