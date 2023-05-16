using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_ZONE_MAPPING")]
public partial class AssetZoneMapping
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AssetCode { get; set; }

    [Column("ZONE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ZoneCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("PACK_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackCode { get; set; }
}
