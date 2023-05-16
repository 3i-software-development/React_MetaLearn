using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_MAINTENANCE_CATEGORY")]
public partial class AssetMaintenanceCategory
{
    [Key]
    [Column("CATEGORY_ID")]
    public int CategoryId { get; set; }

    [Column("CATEGORY_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CategoryCode { get; set; }

    [Column("CATEGORY_NAME")]
    [StringLength(255)]
    public string CategoryName { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("PRICE")]
    public long? Price { get; set; }

    [Column("STATUS_CATEGORY")]
    [StringLength(255)]
    public string StatusCategory { get; set; }

    [Column("NOTE_CATEGORY")]
    [StringLength(500)]
    public string NoteCategory { get; set; }

    [Column("ASSET_CODE_CATEGORY")]
    [StringLength(50)]
    [Unicode(false)]
    public string AssetCodeCategory { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("TOTAL_MONEY_CATEGORY")]
    public long? TotalMoneyCategory { get; set; }

    [Column("USER_CATEGORY")]
    [StringLength(255)]
    public string UserCategory { get; set; }

    [Column("TICKET_CODE_CATEGORY")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCodeCategory { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Currency { get; set; }
}
