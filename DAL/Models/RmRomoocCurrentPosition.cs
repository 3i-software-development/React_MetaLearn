using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_ROMOOC_CURRENT_POSITION")]
public partial class RmRomoocCurrentPosition
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("POSITION_GPS")]
    [StringLength(255)]
    public string PositionGps { get; set; }

    [Column("POSITION_PARKING")]
    [StringLength(255)]
    public string PositionParking { get; set; }

    [Column("POSITION_TEXT")]
    public string PositionText { get; set; }

    [Column("POSITION_TIME")]
    public DateTime? PositionTime { get; set; }

    [Column("REMOOC_CODE")]
    [StringLength(255)]
    public string RemoocCode { get; set; }

    [Column("STATUS")]
    public bool Status { get; set; }

    [Column("TRACTOR_CODE")]
    [StringLength(255)]
    public string TractorCode { get; set; }

    [Column("TRIP_CODE")]
    [StringLength(255)]
    public string TripCode { get; set; }

    [Column("DRIVER_ID")]
    public int? DriverId { get; set; }
}
