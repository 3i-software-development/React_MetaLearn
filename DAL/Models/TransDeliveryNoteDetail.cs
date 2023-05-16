using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("TRANS_DELIVERY_NOTE_DETAIL")]
public partial class TransDeliveryNoteDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DELIVERY_ORDER_NO")]
    [StringLength(255)]
    public string DeliveryOrderNo { get; set; }

    [Column("KIND_OF_GOODS")]
    [StringLength(255)]
    public string KindOfGoods { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("TON", TypeName = "decimal(18, 0)")]
    public decimal? Ton { get; set; }

    [Column("BAGS", TypeName = "decimal(18, 0)")]
    public decimal? Bags { get; set; }

    [Column("LOT_NO")]
    [StringLength(255)]
    public string LotNo { get; set; }

    [Column("REMARK")]
    [StringLength(255)]
    public string Remark { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
