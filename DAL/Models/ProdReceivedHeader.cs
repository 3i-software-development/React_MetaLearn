using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROD_RECEIVED_HEADER")]
public partial class ProdReceivedHeader
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(255)]
    public string TicketCode { get; set; }

    [Column("LOT_PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string LotProductCode { get; set; }

    [Column("CUS_CODE")]
    [StringLength(100)]
    public string CusCode { get; set; }

    [Column("STORE_CODE")]
    [StringLength(100)]
    public string StoreCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("USER_IMPORT")]
    [StringLength(50)]
    public string UserImport { get; set; }

    [Column("USER_SEND")]
    [StringLength(50)]
    public string UserSend { get; set; }

    [Column("COST_TOTAL", TypeName = "decimal(18, 2)")]
    public decimal? CostTotal { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("DISCOUNT", TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column("COMMISSION", TypeName = "decimal(18, 2)")]
    public decimal? Commission { get; set; }

    [Column("TAX_TOTAL", TypeName = "decimal(18, 2)")]
    public decimal? TaxTotal { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("POSITION_GPS")]
    [StringLength(255)]
    public string PositionGps { get; set; }

    [Column("POSITION_TEXT")]
    [StringLength(255)]
    public string PositionText { get; set; }

    [Column("FROM_DEVICE")]
    [StringLength(50)]
    public string FromDevice { get; set; }

    [Column("TOTAL_PAYED", TypeName = "decimal(18, 2)")]
    public decimal? TotalPayed { get; set; }

    [Column("TOTAL_MUST_PAYMENT", TypeName = "decimal(18, 2)")]
    public decimal? TotalMustPayment { get; set; }

    [Column("INSURANT_TIME", TypeName = "datetime")]
    public DateTime? InsurantTime { get; set; }

    [Column("TIME_TICKET_CREATE", TypeName = "datetime")]
    public DateTime? TimeTicketCreate { get; set; }

    [Column("NEXT_TIME_PAYMENT", TypeName = "datetime")]
    public DateTime? NextTimePayment { get; set; }

    [Column("REASON")]
    [StringLength(500)]
    public string Reason { get; set; }

    [Column("STORE_CODE_SEND")]
    [StringLength(100)]
    public string StoreCodeSend { get; set; }

    [Column("PAYMENT_STATUS")]
    [StringLength(50)]
    public string PaymentStatus { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("LOG_DATA")]
    public string LogData { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }
}
