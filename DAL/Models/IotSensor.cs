using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("IOT_SENSOR")]
public partial class IotSensor
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DEVICE_NAME")]
    [StringLength(255)]
    public string DeviceName { get; set; }

    [Column("STRIP_DUE")]
    [StringLength(255)]
    public string StripDue { get; set; }

    [Column("ACCURACY")]
    [StringLength(255)]
    public string Accuracy { get; set; }

    [Column("SPLEEP_DUE")]
    [StringLength(18)]
    [Unicode(false)]
    public string SpleepDue { get; set; }

    [Column("SCREEN")]
    [StringLength(255)]
    public string Screen { get; set; }

    [Column("PIN")]
    [StringLength(255)]
    public string Pin { get; set; }

    [Column("SIZE")]
    [StringLength(1)]
    public string Size { get; set; }

    [Column("MASS")]
    [StringLength(255)]
    [Unicode(false)]
    public string Mass { get; set; }

    [Column("ACCESSORIES")]
    [StringLength(255)]
    public string Accessories { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }

    [Column("LOCATION")]
    [StringLength(255)]
    public string Location { get; set; }

    [Column("MEASUREMENT_TIME")]
    public DateTime? MeasurementTime { get; set; }
}
