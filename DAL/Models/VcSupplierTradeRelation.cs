using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_SUPPLIER_TRADE_RELATION")]
public partial class VcSupplierTradeRelation
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BUYER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Buyer { get; set; }

    [Column("SELLER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Seller { get; set; }

    [Column("BRAND")]
    [StringLength(255)]
    [Unicode(false)]
    public string Brand { get; set; }

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
