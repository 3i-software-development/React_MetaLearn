using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ZONE_DEVICE_PLACEMENT")]
public partial class ZoneDevicePlacement
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DEVICE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceCode { get; set; }

    [Column("ZONE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ZoneCode { get; set; }

    [Column("POSITION")]
    [StringLength(255)]
    public string Position { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("BEGIN_TIME")]
    public DateTime? BeginTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("MANAGER_ID")]
    [StringLength(255)]
    public string ManagerId { get; set; }

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
}
