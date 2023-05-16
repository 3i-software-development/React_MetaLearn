using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LOT_PRODUCT")]
public partial class LotProduct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string QrCode { get; set; }

    [Column("BAR_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string BarCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("SUPPLIER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Supplier { get; set; }

    [Column("EXPIRY_DATE")]
    public DateTime? ExpiryDate { get; set; }

    [Column("COST", TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(7)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("PATH_IMG")]
    [StringLength(255)]
    [Unicode(false)]
    public string PathImg { get; set; }

    [Column("LOT_PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string LotProductCode { get; set; }

    [Column("PACKING")]
    [StringLength(255)]
    public string Packing { get; set; }

    [Column("TAX", TypeName = "money")]
    public decimal? Tax { get; set; }

    [Column("CUSTOM_FEE", TypeName = "money")]
    public decimal? CustomFee { get; set; }

    [Column("POUND_AGE", TypeName = "money")]
    public decimal? PoundAge { get; set; }

    [Column("TRANSFER_COST", TypeName = "money")]
    public decimal? TransferCost { get; set; }

    [Column("DISCOUNT", TypeName = "money")]
    public decimal? Discount { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("LOT_PRODUCT_NAME")]
    [StringLength(255)]
    public string LotProductName { get; set; }

    [Column("STORE")]
    public int? Store { get; set; }

    /// <summary>
    /// xuất xứ
    /// </summary>
    [Column("ORIGIN")]
    [StringLength(255)]
    public string Origin { get; set; }

    /// <summary>
    /// Ngày sản xuất
    /// </summary>
    [Column("MANUFACTURE_DATE")]
    public DateTime? ManufactureDate { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("TAX_MEDIUM", TypeName = "money")]
    public decimal? TaxMedium { get; set; }

    [Column("COST_MEDIUM", TypeName = "money")]
    public decimal? CostMedium { get; set; }
}
