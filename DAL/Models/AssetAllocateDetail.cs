using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("ASSET_ALLOCATE_DETAILS")]
public partial class AssetAllocateDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AssetCode { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("COST_VALUE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CostValue { get; set; }

    [Column("LIST_IMAGES")]
    [StringLength(255)]
    [Unicode(false)]
    public string ListImages { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }
}
