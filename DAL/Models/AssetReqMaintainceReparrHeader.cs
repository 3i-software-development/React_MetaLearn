using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_REQ_MAINTAINCE_REPARR_HEADER")]
public partial class AssetReqMaintainceReparrHeader
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

    [Column("CREATE_BY")]
    [StringLength(255)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(255)]
    public string UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("REASON")]
    [StringLength(255)]
    public string Reason { get; set; }

    [Column("DELETE_BY")]
    [StringLength(255)]
    public string DeleteBy { get; set; }

    [Column("DELETE_TIME")]
    public DateTime? DeleteTime { get; set; }

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }

    [Column("REQ_TIME")]
    public DateTime? ReqTime { get; set; }

    [Column("DISCRIPTION")]
    [StringLength(1000)]
    public string Discription { get; set; }

    [Column("USER_REQ")]
    [StringLength(255)]
    public string UserReq { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    public string Branch { get; set; }

    [Column("TICKET_TYPE")]
    [StringLength(255)]
    public string TicketType { get; set; }

    [Column("LOCATION_REPAIR")]
    [StringLength(255)]
    public string LocationRepair { get; set; }

    [Column("CREATE_DEPART")]
    [StringLength(255)]
    public string CreateDepart { get; set; }

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }
}
