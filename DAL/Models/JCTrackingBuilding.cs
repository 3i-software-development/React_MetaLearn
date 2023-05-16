using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("JC_TRACKING_BUILDING")]
public partial class JcTrackingBuilding
{
    [Column("ID")]
    public int Id { get; set; }

    [Key]
    [Column("JCT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string JctCode { get; set; }

    [Column("JOB_CARD_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string JobCardCode { get; set; }

    [Column("PROGRESS")]
    [StringLength(255)]
    public string Progress { get; set; }

    [Column("LOCATION_TEXT")]
    [StringLength(255)]
    public string LocationText { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(255)]
    public string LocationGps { get; set; }

    [Column("TEAM_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TeamCode { get; set; }

    [Column("DEVICE")]
    [StringLength(255)]
    public string Device { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
