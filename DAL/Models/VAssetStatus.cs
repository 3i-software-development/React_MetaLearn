using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAssetStatus
{
    [Required]
    [Column("TYPE")]
    [StringLength(20)]
    public string Type { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("YEAR")]
    public int? Year { get; set; }
}
