using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("ASSET_BUY_HEADER")]
public partial class AssetBuyHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("BRANCH")]
    [StringLength(100)]
    public string Branch { get; set; }

    [Column("BUYER")]
    [StringLength(255)]
    public string Buyer { get; set; }

    [Column("LOCATION")]
    [StringLength(255)]
    public string Location { get; set; }

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

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("BUY_TIME")]
    public DateTime? BuyTime { get; set; }

    [Column("TOTAL_MONEY")]
    public int? TotalMoney { get; set; }

    [Column("DEPART")]
    [StringLength(255)]
    public string Depart { get; set; }

    [Column("CURRENCY")]
    [StringLength(100)]
    [Unicode(false)]
    public string Currency { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }
}
