using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PO_BUYER_HEADER")]
public partial class PoBuyerHeader
{
    [Key]
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

    /// <summary>
    /// Date of order
    /// </summary>
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

    /// <summary>
    /// Người gửi hàng
    /// </summary>
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

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }

    [Column("STATUS_LOG")]
    public string StatusLog { get; set; }

    [Column("STATUS_OBJECT")]
    [StringLength(255)]
    public string StatusObject { get; set; }

    [Column("STATUS_OBJECT_LOG")]
    public string StatusObjectLog { get; set; }
}
