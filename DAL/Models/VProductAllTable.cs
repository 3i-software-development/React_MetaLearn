using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VProductAllTable
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(500)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(255)]
    public string ProductName { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("PRICE_COST_CATELOGUE", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostCatelogue { get; set; }

    [Column("PRICE_COST_AIRLINE", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostAirline { get; set; }

    [Column("PRICE_COST_SEA", TypeName = "decimal(18, 2)")]
    public decimal? PriceCostSea { get; set; }

    [Column("PRICE_RETAIL_BUILD", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailBuild { get; set; }

    [Column("PRICE_RETAIL_BUILD_AIRLINE", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailBuildAirline { get; set; }

    [Column("PRICE_RETAIL_BUILD_SEA", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailBuildSea { get; set; }

    [Column("PRICE_RETAIL_NO_BUILD", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailNoBuild { get; set; }

    [Column("PRICE_RETAIL_NO_BUILD_AIRLINE", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailNoBuildAirline { get; set; }

    [Column("PRICE_RETAIL_NO_BUILD_SEA", TypeName = "decimal(18, 2)")]
    public decimal? PriceRetailNoBuildSea { get; set; }

    [Required]
    [Column("PRODUCT_TYPE")]
    [StringLength(16)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("PRODUCT_TYPE_NAME")]
    [StringLength(500)]
    public string ProductTypeName { get; set; }

    [Column("UNIT_NAME")]
    [StringLength(255)]
    public string UnitName { get; set; }
}
