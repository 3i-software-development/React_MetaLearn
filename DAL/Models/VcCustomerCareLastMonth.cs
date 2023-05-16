using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_CUSTOMER_CARE_LAST_MONTH")]
public partial class VcCustomerCareLastMonth
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("YEAR_MONTH")]
    [StringLength(10)]
    [Unicode(false)]
    public string YearMonth { get; set; }

    [Required]
    [Column("CUS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CusCode { get; set; }

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

    [Column("CONSUMP_MONTHLY", TypeName = "decimal(18, 1)")]
    public decimal? ConsumpMonthly { get; set; }

    [Column("INSTOCK", TypeName = "decimal(18, 1)")]
    public decimal? Instock { get; set; }

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

    [Column("USERNAME")]
    [StringLength(50)]
    public string Username { get; set; }
}
