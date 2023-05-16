using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ZONE_SETUP")]
public partial class ZoneSetup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ZONE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ZoneCode { get; set; }

    [Column("ZONE_NAME")]
    [StringLength(255)]
    public string ZoneName { get; set; }

    [Column("ZONE_ADDRESS_TXT")]
    [StringLength(1000)]
    public string ZoneAddressTxt { get; set; }

    [Column("ZONE_ADDRESS_GPS")]
    [StringLength(255)]
    public string ZoneAddressGps { get; set; }

    [Column("ZONE_IMAGE")]
    [StringLength(255)]
    public string ZoneImage { get; set; }

    [Column("ZONE_DESC")]
    [StringLength(1000)]
    public string ZoneDesc { get; set; }

    [Column("ZONE_STATUS")]
    [StringLength(255)]
    public string ZoneStatus { get; set; }

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
