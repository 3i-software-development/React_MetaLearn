using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SUB_PRODUCT")]
public partial class SubProduct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    public string ProductCode { get; set; }

    [Column("ATTRIBUTE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AttributeCode { get; set; }

    [Column("ATTRIBUTE_NAME")]
    [StringLength(255)]
    public string AttributeName { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(500)]
    public string ProductQrCode { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("VALUE")]
    public string Value { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("IN_STOCK", TypeName = "decimal(18, 2)")]
    public decimal? InStock { get; set; }

    [Column("FORECAST_IN_STOCK", TypeName = "decimal(18, 2)")]
    public decimal? ForecastInStock { get; set; }

    [Column("FORECAST_TIME")]
    public DateTime? ForecastTime { get; set; }

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

    /// <summary>
    /// Giá /m...
    /// </summary>
    [Column("PRICE_PER_M", TypeName = "decimal(18, 2)")]
    public decimal? PricePerM { get; set; }

    /// <summary>
    /// Giá / m2
    /// </summary>
    [Column("PRICE_PER_M2", TypeName = "decimal(18, 2)")]
    public decimal? PricePerM2 { get; set; }

    [Column("IMP_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ImpType { get; set; }
}
