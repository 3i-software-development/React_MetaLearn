using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_CUSTOMER_DECLARE_INFO")]
public partial class VcCustomerDeclareInfo
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("BRAND_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string BrandCode { get; set; }

    [Required]
    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("BUY_COST", TypeName = "decimal(18, 3)")]
    public decimal? BuyCost { get; set; }

    [Column("SALE_COST", TypeName = "decimal(18, 3)")]
    public decimal? SaleCost { get; set; }

    [Column("CONSUMP_MONTHLY", TypeName = "decimal(18, 3)")]
    public decimal? ConsumpMonthly { get; set; }

    [Column("INSTOCK", TypeName = "decimal(18, 3)")]
    public decimal? Instock { get; set; }

    [Column("PROPORTION", TypeName = "decimal(18, 0)")]
    public decimal? Proportion { get; set; }

    [Column("TOTAL_CAN_IMP", TypeName = "decimal(18, 3)")]
    public decimal? TotalCanImp { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

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
}
