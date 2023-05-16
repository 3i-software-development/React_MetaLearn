using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("IOT_WARNING_SETTING")]
public partial class IotWarningSetting
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjType { get; set; }

    [Column("DEVICE_CODE")]
    [StringLength(100)]
    public string DeviceCode { get; set; }

    [Column("CLOSE_BELOW", TypeName = "decimal(18, 0)")]
    public decimal? CloseBelow { get; set; }

    [Column("CLOSE_ON", TypeName = "decimal(18, 0)")]
    public decimal? CloseOn { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("LOCATION")]
    [StringLength(255)]
    [Unicode(false)]
    public string Location { get; set; }
}
