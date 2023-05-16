using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("COST_TABLE_LOG")]
public partial class CostTableLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("HEADER_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string HeaderCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("PRICE_RETAIL", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetail { get; set; }

    [Column("TAX")]
    public int? Tax { get; set; }

    [Column("COMMISSION", TypeName = "decimal(18, 2)")]
    public decimal? Commission { get; set; }

    [Column("DISCOUNT", TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column("CUSTOM_FEE", TypeName = "decimal(18, 2)")]
    public decimal? CustomFee { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("PRICE_COST", TypeName = "decimal(18, 2)")]
    public decimal? PriceCost { get; set; }

    /// <summary>
    /// Giá đại lý catalogue
    /// </summary>
    [Column("PRICE_COST_CATELOGUE", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostCatelogue { get; set; }

    /// <summary>
    /// Giá đại lý đường bay
    /// </summary>
    [Column("PRICE_COST_AIRLINE", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostAirline { get; set; }

    /// <summary>
    /// Giá đại lý đường biển
    /// </summary>
    [Column("PRICE_COST_SEA", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostSea { get; set; }

    /// <summary>
    /// Giá bán lẻ có thi công
    /// </summary>
    [Column("PRICE_RETAIL_BUILD", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailBuild { get; set; }

    /// <summary>
    /// Giá bán lẻ có thi công bay
    /// </summary>
    [Column("PRICE_RETAIL_BUILD_AIRLINE", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailBuildAirline { get; set; }

    /// <summary>
    /// Giá bán lẻ có thi công kho,biển
    /// </summary>
    [Column("PRICE_RETAIL_BUILD_SEA", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailBuildSea { get; set; }

    /// <summary>
    /// Giá bán lẻ không thi công
    /// </summary>
    [Column("PRICE_RETAIL_NO_BUILD", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailNoBuild { get; set; }

    /// <summary>
    /// Giá bán lẻ không thi công bay
    /// </summary>
    [Column("PRICE_RETAIL_NO_BUILD_AIRLINE", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailNoBuildAirline { get; set; }

    /// <summary>
    /// Giá bán lẻ không thi công kho, biển
    /// </summary>
    [Column("PRICE_RETAIL_NO_BUILD_SEA", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailNoBuildSea { get; set; }

    [Column("CATELOGUE")]
    [StringLength(255)]
    public string Catelogue { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }

    [Column("CHANGE_NUMBER")]
    public int? ChangeNumber { get; set; }

    [Column("RECORD_STATUS")]
    [StringLength(255)]
    public string RecordStatus { get; set; }

    [Column("PRICE_COST_DEFAULT", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostDefault { get; set; }
}
