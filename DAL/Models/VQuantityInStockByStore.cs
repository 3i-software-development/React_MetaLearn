using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VQuantityInStockByStore
{
    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(100)]
    public string ProductQrCode { get; set; }

    [Column("STORE_CODE")]
    [StringLength(100)]
    public string StoreCode { get; set; }

    [Column("TOTAL_QUANTITY_BY_STORE", TypeName = "decimal(38, 2)")]
    public decimal? TotalQuantityByStore { get; set; }

    [Column("TOTAL_QUANTITY_IN_STORE", TypeName = "decimal(38, 2)")]
    public decimal? TotalQuantityInStore { get; set; }
}
