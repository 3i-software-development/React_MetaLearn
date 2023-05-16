using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MATERIAL_STORE_BATCH_GOODS")]
public partial class MaterialStoreBatchGood
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("NAME")]
    [StringLength(250)]
    public string Name { get; set; }

    [Column("DATE_REICEIVE")]
    public DateTime? DateReiceive { get; set; }

    [Column("DATE_PRODUCE")]
    public DateTime? DateProduce { get; set; }

    [Column("DATE_EXPIRE")]
    public DateTime? DateExpire { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("SUPPLIER_ID")]
    public int? SupplierId { get; set; }

    [Column("UNIT")]
    [StringLength(250)]
    public string Unit { get; set; }

    [Column("STORE_ID")]
    public int? StoreId { get; set; }

    [Column("BARCODE")]
    [StringLength(20)]
    [Unicode(false)]
    public string Barcode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("BLOCK_CODE")]
    [StringLength(100)]
    public string BlockCode { get; set; }

    [Column("MADEIN")]
    [StringLength(100)]
    public string Madein { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("PACKING")]
    [StringLength(500)]
    public string Packing { get; set; }

    [Column("COST")]
    public double? Cost { get; set; }

    [Column("SALE")]
    public int? Sale { get; set; }

    [Column("CURRENCY")]
    [StringLength(100)]
    public string Currency { get; set; }

    [Column("VAT")]
    public int? Vat { get; set; }

    [Column("TOTAL")]
    public double? Total { get; set; }

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
}
