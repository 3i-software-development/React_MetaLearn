using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_AUTHORING")]
public partial class AdAuthoring
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FROM_USER")]
    [StringLength(50)]
    [Unicode(false)]
    public string FromUser { get; set; }

    [Column("TO_USER")]
    [StringLength(50)]
    [Unicode(false)]
    public string ToUser { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("CONFIRM")]
    [StringLength(255)]
    [Unicode(false)]
    public string Confirm { get; set; }
}
