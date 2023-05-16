using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class PoSaleHeaderNotDone
{
    [Column("CONTRACT_HEADER_ID")]
    public int ContractHeaderId { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    public string ContractCode { get; set; }

    [Column("TITLE")]
    [StringLength(1000)]
    public string Title { get; set; }

    [Column("CONTRACT_TYPE")]
    [StringLength(50)]
    public string ContractType { get; set; }

    [Column("CONTRACT_DATE")]
    public DateTime? ContractDate { get; set; }

    [Column("CONTRACT_NO")]
    [StringLength(100)]
    public string ContractNo { get; set; }

    [Column("DURATION")]
    [StringLength(100)]
    public string Duration { get; set; }

    [Column("VERSION")]
    public int? Version { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    [Column("SIGNER")]
    [StringLength(100)]
    public string Signer { get; set; }

    [Column("MAIN_SERVICE")]
    [StringLength(255)]
    public string MainService { get; set; }

    [Column("BUDGET", TypeName = "decimal(18, 2)")]
    public decimal? Budget { get; set; }

    [Column("CURRENCY")]
    [StringLength(20)]
    public string Currency { get; set; }

    [Column("LOCATION_HARD_COPY")]
    [StringLength(255)]
    public string LocationHardCopy { get; set; }

    [Column("DESCRIBE")]
    [StringLength(500)]
    public string Describe { get; set; }

    [Column("CUS_CODE")]
    [StringLength(100)]
    public string CusCode { get; set; }

    [Column("CONTRACT_RELATIVE")]
    public string ContractRelative { get; set; }

    [Column("TAGS")]
    [StringLength(50)]
    public string Tags { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

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

    [Column("EFFECTIVE_DATE")]
    public DateTime? EffectiveDate { get; set; }

    [Column("END_DATE")]
    public DateTime? EndDate { get; set; }

    [Column("REAL_BUDGET", TypeName = "decimal(18, 2)")]
    public decimal? RealBudget { get; set; }

    [Column("CONFIRM")]
    public string Confirm { get; set; }

    [Column("ESTIMATE_TIME")]
    public DateTime? EstimateTime { get; set; }

    [Column("LOG_PRODUCT_DETAIL")]
    public string LogProductDetail { get; set; }

    [Column("PRJ_CODE")]
    [StringLength(255)]
    public string PrjCode { get; set; }

    [Column("BUDGET_EXCLUDE_TAX", TypeName = "decimal(18, 2)")]
    public decimal? BudgetExcludeTax { get; set; }

    [Column("TAX_AMOUNT", TypeName = "decimal(18, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column("EXCHANGE_RATE", TypeName = "decimal(18, 2)")]
    public decimal? ExchangeRate { get; set; }

    [Column("ACCEPTANCE_TIME")]
    public DateTime? AcceptanceTime { get; set; }

    [Column("MAINTENANCE")]
    public int? Maintenance { get; set; }

    [Column("LOG_DATA")]
    public string LogData { get; set; }

    [Column("COMMISSION", TypeName = "decimal(18, 2)")]
    public decimal? Commission { get; set; }

    [Column("DISCOUNT", TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column("LAST_BUDGET", TypeName = "decimal(18, 2)")]
    public decimal? LastBudget { get; set; }

    [Column("IS_CHANGE_PRODUCT")]
    public bool? IsChangeProduct { get; set; }

    [Column("LIST_USER_VIEW")]
    [Unicode(false)]
    public string ListUserView { get; set; }
}
