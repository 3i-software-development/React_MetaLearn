using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASP_NET_ROLES")]
[Index("NormalizedName", Name = "ROLE_NAME_INDEX", IsUnique = true)]
public partial class AspNetRole
{
    [Key]
    [Column("ID")]
    [StringLength(50)]
    public string Id { get; set; }

    [Column("CONCURRENCY_STAMP")]
    [StringLength(255)]
    public string ConcurrencyStamp { get; set; }

    [Column("NAME")]
    [StringLength(256)]
    public string Name { get; set; }

    [Column("NORMALIZED_NAME")]
    [StringLength(256)]
    public string NormalizedName { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    public string Code { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(2000)]
    public string Description { get; set; }

    [Column("ORD")]
    public int? Ord { get; set; }

    [Column("STATUS")]
    public bool Status { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("PRIORITY")]
    public int? Priority { get; set; }

    [Column("COLOR")]
    [StringLength(255)]
    public string Color { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("TYPE_ROLE")]
    [StringLength(255)]
    public string TypeRole { get; set; }
}
