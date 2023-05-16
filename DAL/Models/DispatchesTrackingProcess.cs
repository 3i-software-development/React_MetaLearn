using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_TRACKING_PROCESS")]
public partial class DispatchesTrackingProcess
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DISPATCH_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string DispatchCode { get; set; }

    [Column("FROM_NODE")]
    [StringLength(100)]
    public string FromNode { get; set; }

    [Column("NODE_PROARS")]
    [StringLength(100)]
    public string NodeProars { get; set; }

    [Column("IS_UP")]
    public bool? IsUp { get; set; }

    [Column("DEAD_LINE")]
    public DateTime? DeadLine { get; set; }

    [Column("MEMBER_LIST")]
    public string MemberList { get; set; }

    [Column("PROCESS_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProcessCode { get; set; }

    [Column("COMMENT")]
    public string Comment { get; set; }

    [Column("FILE_LIST")]
    public string FileList { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("TO_NODE")]
    [StringLength(255)]
    public string ToNode { get; set; }

    [Column("ACTION")]
    [StringLength(100)]
    [Unicode(false)]
    public string Action { get; set; }

    [Column("STEP")]
    public int? Step { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("REASON")]
    public string Reason { get; set; }

    [Column("COORDINATE")]
    [StringLength(255)]
    public string Coordinate { get; set; }

    [Column("RECEIVED")]
    [StringLength(255)]
    [Unicode(false)]
    public string Received { get; set; }

    [Column("VIEWER_LIST")]
    public string ViewerList { get; set; }
}
