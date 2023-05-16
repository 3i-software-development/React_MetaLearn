using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class PoBuyerHeaderNotDone
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("BUYER_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string BuyerCode { get; set; }

    [Column("SUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string SupCode { get; set; }

    [Column("PO_TITLE")]
    [StringLength(255)]
    public string PoTitle { get; set; }

    [Column("PO_SUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoSupCode { get; set; }

    [Column("DATE_OF_ORDER")]
    public DateTime? DateOfOrder { get; set; }

    [Column("ORDER_BY")]
    [StringLength(255)]
    public string OrderBy { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    [Unicode(false)]
    public string Email { get; set; }

    [Column("PAYMENT_TERM")]
    public string PaymentTerm { get; set; }

    [Column("SHIPPING_ADD")]
    [StringLength(255)]
    public string ShippingAdd { get; set; }

    [Column("CONSIGNER")]
    [StringLength(255)]
    public string Consigner { get; set; }

    [Column("MOBILE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Mobile { get; set; }

    [Column("BUYER")]
    [StringLength(255)]
    public string Buyer { get; set; }

    [Column("NOTED")]
    [StringLength(500)]
    public string Noted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("APPROVED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string ApprovedBy { get; set; }

    [Column("APPROVED_TIME")]
    public DateTime? ApprovedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CONFIRM")]
    public string Confirm { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("ESTIMATE_TIME", TypeName = "date")]
    public DateTime? EstimateTime { get; set; }

    [Column("TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("CURRENCY")]
    [StringLength(20)]
    public string Currency { get; set; }

    [Column("EXCHANGE_RATE", TypeName = "decimal(18, 2)")]
    public decimal? ExchangeRate { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ContractCode { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProjectCode { get; set; }

    [Column("LIST_USER_VIEW")]
    [Unicode(false)]
    public string ListUserView { get; set; }
}
