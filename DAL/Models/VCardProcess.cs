using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VCardProcess
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("WEIGHT_NUM", TypeName = "decimal(14, 2)")]
    public decimal WeightNum { get; set; }

    [Column("MONTH")]
    public int? Month { get; set; }

    [Column("PROGRESS", TypeName = "decimal(14, 0)")]
    public decimal? Progress { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(100)]
    public string BoardCode { get; set; }

    [Column("YEAR")]
    public int? Year { get; set; }

    [Column("OBJ_ID")]
    [StringLength(255)]
    public string ObjId { get; set; }
}
