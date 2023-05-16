using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("IOT_DEVICE_INFO")]
public partial class IotDeviceInfo
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DEVICE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceCode { get; set; }

    [Column("DEVICE_NAME")]
    [StringLength(255)]
    public string DeviceName { get; set; }

    [Column("DEVICE_GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceGroup { get; set; }

    [Column("DEVICE_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceType { get; set; }

    [Column("DEVICE_MANUFACTURER")]
    [StringLength(255)]
    public string DeviceManufacturer { get; set; }

    [Column("DEVICE_STATUS")]
    [StringLength(255)]
    public string DeviceStatus { get; set; }

    [Column("DEVICE_DESC")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceDesc { get; set; }

    [Column("DEVICE_IMAGE")]
    [StringLength(255)]
    public string DeviceImage { get; set; }

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

    [Column("DEVICE_SVG")]
    public string DeviceSvg { get; set; }
}
