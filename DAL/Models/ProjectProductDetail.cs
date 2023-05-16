using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("PROJECT_PRODUCT_DETAIL")]
public partial class ProjectProductDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("COST", TypeName = "decimal(18, 0)")]
    public decimal? Cost { get; set; }

    [Column("SUPPLIER_CODE")]
    [StringLength(255)]
    public string SupplierCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
