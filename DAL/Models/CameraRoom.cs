using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CAMERA_ROOM")]
public partial class CameraRoom
{
    [Column("DEPARTMENT_CODE")]
    [StringLength(150)]
    public string DepartmentCode { get; set; }

    [Column("ROOM_ID")]
    [StringLength(150)]
    public string RoomId { get; set; }

    [Column("ROOM_NAME")]
    [StringLength(150)]
    public string RoomName { get; set; }

    [Column("CAMERA_QUANTITY")]
    public int? CameraQuantity { get; set; }

    [Column("CAMERA_AVAILABLE")]
    public int? CameraAvailable { get; set; }

    [Column("SERIES")]
    [StringLength(50)]
    public string Series { get; set; }

    [Column("CAPACITY")]
    [StringLength(50)]
    public string Capacity { get; set; }

    [Column("DISK_STATUS")]
    [StringLength(50)]
    public string DiskStatus { get; set; }

    [Column("SIGNAL_LOSS_REASON")]
    [StringLength(150)]
    public string SignalLossReason { get; set; }

    [Column("NOTE")]
    [StringLength(150)]
    public string Note { get; set; }

    [Column("DISK_SAVEABLE")]
    public bool? DiskSaveable { get; set; }

    [Column("LOGIN_INFORMATION")]
    [StringLength(100)]
    public string LoginInformation { get; set; }

    [Column("IMAGE_LINK")]
    [StringLength(100)]
    public string ImageLink { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }
}
