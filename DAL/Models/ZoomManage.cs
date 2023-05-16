using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ZOOM_MANAGE")]
public partial class ZoomManage
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ZOOM_ID")]
    [StringLength(100)]
    [Unicode(false)]
    public string ZoomId { get; set; }

    [Column("ZOOM_NAME")]
    [StringLength(255)]
    public string ZoomName { get; set; }

    [Column("ZOOM_PASSWORD")]
    [StringLength(100)]
    [Unicode(false)]
    public string ZoomPassword { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

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

    [Column("ACCOUNT_ZOOM")]
    [StringLength(255)]
    [Unicode(false)]
    public string AccountZoom { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("LIST_USER_ACCESS")]
    public string ListUserAccess { get; set; }

    [Column("LIST_USER_JOIN")]
    public string ListUserJoin { get; set; }

    [Column("CHANEL")]
    [StringLength(255)]
    public string Chanel { get; set; }

    [Column("JOIN_URL")]
    [StringLength(1000)]
    public string JoinUrl { get; set; }

    [Column("MEETING_SCHEDULE_ID")]
    public int? MeetingScheduleId { get; set; }

    [Column("HOST_CLAIM_CODE")]
    [StringLength(255)]
    public string HostClaimCode { get; set; }
}
