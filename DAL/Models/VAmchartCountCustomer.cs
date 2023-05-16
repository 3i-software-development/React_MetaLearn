using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartCountCustomer
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("MONTH")]
    public int? Month { get; set; }

    [Column("INCOME")]
    public int? Income { get; set; }
}
