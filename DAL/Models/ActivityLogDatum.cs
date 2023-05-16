using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ACTIVITY_LOG_DATA")]
public partial class ActivityLogDatum
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ActCode { get; set; }

    [Column("WORK_FLOW_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string WorkFlowCode { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    [Column("ACT_TIME")]
    public DateTime? ActTime { get; set; }

    [Column("ACT_LOCATION_GPS", TypeName = "decimal(18, 0)")]
    public decimal? ActLocationGps { get; set; }

    [Column("ACT_FROM_DEVICE")]
    [StringLength(255)]
    public string ActFromDevice { get; set; }

    [Column("ACT_TYPE")]
    [StringLength(255)]
    public string ActType { get; set; }

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

    [Column("LOG")]
    public string Log { get; set; }
}
