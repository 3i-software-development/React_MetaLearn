using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("STOCK_ARRANGE_POP_ENTRY")]
public partial class StockArrangePopEntry
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("MAP_ID")]
    public int? MapId { get; set; }

    [Column("PROD_CODE")]
    [StringLength(255)]
    public string ProdCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column("MARK_WHOLE_PRODUCT")]
    public bool? MarkWholeProduct { get; set; }

    [Column("UNIT_EXP")]
    [StringLength(18)]
    public string UnitExp { get; set; }
}
