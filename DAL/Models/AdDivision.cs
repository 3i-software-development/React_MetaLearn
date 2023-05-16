using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_DIVISION")]
public partial class AdDivision
{
    [Key]
    [Column("DIVISION")]
    [StringLength(255)]
    public string Division { get; set; }

    [Column("DIVISION_DESC")]
    [StringLength(255)]
    public string DivisionDesc { get; set; }

    [Column("UPDATE_TIME")]
    [StringLength(50)]
    public string UpdateTime { get; set; }
}
