using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("GALAXY_KEYWORD")]
public partial class GalaxyKeyword
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("KEYWORD")]
    public string Keyword { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
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
