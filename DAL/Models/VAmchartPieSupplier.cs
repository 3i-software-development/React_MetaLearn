using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartPieSupplier
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    [Column("COUNTRY")]
    [StringLength(255)]
    public string Country { get; set; }

    [Column("LITRES")]
    public int? Litres { get; set; }
}
