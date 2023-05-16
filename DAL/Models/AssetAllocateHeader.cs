using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("ASSET_ALLOCATE_HEADER")]
public partial class AssetAllocateHeader
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

    [Column("DEPARTMENT_SEND")]
    [StringLength(255)]
    public string DepartmentSend { get; set; }

    [Column("USER_ALLOCATE")]
    [StringLength(255)]
    public string UserAllocate { get; set; }

    [Column("LOCATION_SEND")]
    [StringLength(255)]
    public string LocationSend { get; set; }

    [Column("ALLOCATE_TIME")]
    public DateTime? AllocateTime { get; set; }

    [Column("USER_RECEIVER")]
    [StringLength(50)]
    public string UserReceiver { get; set; }

    [Column("DEPARTMENT_RECEIVE")]
    [StringLength(255)]
    public string DepartmentReceive { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }

    [Column("QR_CODE")]
    [Unicode(false)]
    public string QrCode { get; set; }
}
