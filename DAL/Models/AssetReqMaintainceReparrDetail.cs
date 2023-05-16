using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_REQ_MAINTAINCE_REPARR_DETAIL")]
public partial class AssetReqMaintainceReparrDetail
{
    [Column("COST_VALUE")]
    public int? CostValue { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("CREATE_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(100)]
    public string UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("DELETE_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeleteBy { get; set; }

    [Column("DELETE_TIME")]
    public DateTime? DeleteTime { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Note { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(255)]
    public string AssetCode { get; set; }

    [Column("STATUS_ASSET")]
    [StringLength(255)]
    public string StatusAsset { get; set; }

    [Column("TICKET_TYPE")]
    [StringLength(255)]
    public string TicketType { get; set; }

    [Column("ASSET_TYPE")]
    [StringLength(255)]
    public string AssetType { get; set; }

    [Column("PROPERTY")]
    [StringLength(255)]
    public string Property { get; set; }

    [Column("ASSET_NAME")]
    [StringLength(255)]
    public string AssetName { get; set; }
}
