using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VHisExpProduct
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("TICKET_EXP_CODE")]
    [StringLength(255)]
    public string TicketExpCode { get; set; }

    [Column("PO_SUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoSupCode { get; set; }

    [Column("SUP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string SupCode { get; set; }

    [Column("SUP_NAME")]
    [StringLength(255)]
    public string SupName { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(255)]
    public string ProductQrCode { get; set; }

    [Column("TICKET_IMP_CODE")]
    [StringLength(255)]
    public string TicketImpCode { get; set; }

    [Column("PO_CUS_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoCusCode { get; set; }

    [Column("CUS_CODE")]
    [StringLength(100)]
    public string CusCode { get; set; }

    [Column("CUS_NAME")]
    [StringLength(255)]
    public string CusName { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("UNIT_NAME")]
    [StringLength(255)]
    public string UnitName { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UNIT_PRICE", TypeName = "decimal(18, 0)")]
    public decimal? UnitPrice { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("CURRENCY_NAME")]
    [StringLength(255)]
    public string CurrencyName { get; set; }
}
