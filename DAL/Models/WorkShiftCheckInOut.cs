using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_SHIFT_CHECKIN_OUT")]
public partial class WorkShiftCheckinOut
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTION")]
    [StringLength(50)]
    [Unicode(false)]
    public string Action { get; set; }

    [Column("ACTION_TIME")]
    public DateTime ActionTime { get; set; }

    [Column("ACTION_TO")]
    public DateTime? ActionTo { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(255)]
    [Unicode(false)]
    public string LocationGps { get; set; }

    [Column("LOCATION_TEXT")]
    [StringLength(255)]
    public string LocationText { get; set; }

    [Column("DEVICE")]
    [StringLength(50)]
    public string Device { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("PICTURE")]
    [StringLength(255)]
    public string Picture { get; set; }

    [Column("IP")]
    [StringLength(50)]
    public string Ip { get; set; }

    [Column("SESSION")]
    public int Session { get; set; }

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

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("SHIFT_CODE")]
    [StringLength(255)]
    public string ShiftCode { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("APPROVE")]
    public bool? Approve { get; set; }

    [Column("NOT_WORK_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string NotWorkType { get; set; }

    [Column("WORK_HOLIDAY")]
    public bool? WorkHoliday { get; set; }

    [Column("IS_EXCEPTION")]
    public bool? IsException { get; set; }

    [Column("APPROVER")]
    [StringLength(255)]
    public string Approver { get; set; }

    [Column("APPROVE_TIME")]
    public DateTime? ApproveTime { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("STATUS_LOG")]
    public string StatusLog { get; set; }

    [Column("WORKFLOW_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCode { get; set; }
}
