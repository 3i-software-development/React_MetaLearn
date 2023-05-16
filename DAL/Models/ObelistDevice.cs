using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OBE_LIST_DEVICE")]
public partial class ObeListDevice
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("DEVICE_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceId { get; set; }

    [Column("DEVICE_TITLE")]
    [StringLength(150)]
    public string DeviceTitle { get; set; }

    [Column("VENDOR")]
    [StringLength(100)]
    [Unicode(false)]
    public string Vendor { get; set; }

    [Column("POSITION_DEVICE")]
    [StringLength(255)]
    public string PositionDevice { get; set; }

    [Column("ACCOUNT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Account { get; set; }

    [Column("DESCRIBE")]
    [StringLength(255)]
    public string Describe { get; set; }

    [Column("DEVICE_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceType { get; set; }

    [Column("STATUS")]
    public int Status { get; set; }
}
