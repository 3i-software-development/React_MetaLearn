using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MATERIAL_PRODUCT")]
public partial class MaterialProduct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(255)]
    public string ProductName { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(50)]
    public string GroupCode { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("ACCESSORY")]
    public int? Accessory { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("BARCODE")]
    public string Barcode { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("TYPE_CODE")]
    [StringLength(50)]
    public string TypeCode { get; set; }

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

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("QR_CODE")]
    public string QrCode { get; set; }

    [Column("MATERIAL")]
    [StringLength(1000)]
    public string Material { get; set; }

    [Column("PATTERN")]
    [StringLength(1000)]
    public string Pattern { get; set; }

    [Column("INHERITANCE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Inheritance { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("IN_STOCK", TypeName = "decimal(18, 2)")]
    public decimal? InStock { get; set; }

    [Column("FORECAST_IN_STOCK", TypeName = "decimal(18, 2)")]
    public decimal? ForecastInStock { get; set; }

    [Column("FORECAST_TIME")]
    public DateTime? ForecastTime { get; set; }

    [Column("PRICE_PER_M", TypeName = "decimal(18, 0)")]
    public decimal? PricePerM { get; set; }

    [Column("PRICE_PER_M2", TypeName = "decimal(18, 0)")]
    public decimal? PricePerM2 { get; set; }

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

    [Column("LABEL")]
    [StringLength(255)]
    public string Label { get; set; }

    [Column("WIDE", TypeName = "decimal(18, 2)")]
    public decimal? Wide { get; set; }

    [Column("HIGH", TypeName = "decimal(18, 2)")]
    public decimal? High { get; set; }

    [Column("IMP_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ImpType { get; set; }

    [Column("TYPE_CODE2")]
    [StringLength(50)]
    [Unicode(false)]
    public string TypeCode2 { get; set; }

    [Column("PACKING")]
    [StringLength(255)]
    public string Packing { get; set; }

    [Column("WEIGHT", TypeName = "decimal(18, 2)")]
    public decimal? Weight { get; set; }

    [Column("UNIT_WEIGHT")]
    [StringLength(255)]
    public string UnitWeight { get; set; }

    [Column("JSON")]
    [StringLength(255)]
    public string Json { get; set; }

    [Column("LONG", TypeName = "decimal(18, 2)")]
    public decimal? Long { get; set; }

    [Column("SUPPLIER")]
    [StringLength(255)]
    public string Supplier { get; set; }

    [Column("BRAND")]
    [StringLength(255)]
    public string Brand { get; set; }
}
