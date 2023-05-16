using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MAP_STOCK_PROD_IN")]
public partial class MapStockProdIn
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("MAP_ID")]
    public int? MapId { get; set; }

    [Column("PROD_CODE")]
    [StringLength(255)]
    public string ProdCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("PARENT_ID")]
    public int? ParentId { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
