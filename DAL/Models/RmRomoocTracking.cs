using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_ROMOOC_TRACKING")]
public partial class RmRomoocTracking
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("DRIVER_ID")]
    public int? DriverId { get; set; }

    [Column("END_POSITION_GPS")]
    [StringLength(1000)]
    public string EndPositionGps { get; set; }

    [Column("END_POSITION_CODE")]
    [StringLength(255)]
    public string EndPositionCode { get; set; }

    [Column("END_POSITION_TEXT")]
    [StringLength(255)]
    public string EndPositionText { get; set; }

    [Column("END_POSITION_TIME")]
    public DateTime? EndPositionTime { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("REMOOC_CODE")]
    [StringLength(255)]
    public string RemoocCode { get; set; }

    [Column("START_POSITION_GPS")]
    [StringLength(1000)]
    public string StartPositionGps { get; set; }

    [Column("START_POSITION_CODE")]
    [StringLength(255)]
    public string StartPositionCode { get; set; }

    [Column("START_POSITION_TEXT")]
    [StringLength(255)]
    public string StartPositionText { get; set; }

    [Column("START_POSITION_TIME")]
    public DateTime? StartPositionTime { get; set; }

    [Column("TRACTOR_CODE")]
    [StringLength(255)]
    public string TractorCode { get; set; }

    [Column("TRIP_CODE")]
    [StringLength(255)]
    public string TripCode { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("CONTAINER_CODE")]
    [StringLength(255)]
    public string ContainerCode { get; set; }

    [Column("IMGCONTAIN1")]
    [StringLength(255)]
    public string Imgcontain1 { get; set; }

    [Column("IMGCONTAIN2")]
    [StringLength(255)]
    public string Imgcontain2 { get; set; }

    [Column("CREATE_BY")]
    [StringLength(255)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(255)]
    public string UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("INIT_POSITION_TEXT")]
    [StringLength(255)]
    public string InitPositionText { get; set; }

    [Column("INIT_POSITION_TIME")]
    public DateTime? InitPositionTime { get; set; }

    [Column("TYPE_TRIP")]
    [StringLength(255)]
    public string TypeTrip { get; set; }

    [Column("MA_THEO_DOI")]
    [StringLength(255)]
    public string MaTheoDoi { get; set; }

    [Column("BAND")]
    [StringLength(255)]
    public string Band { get; set; }

    [Column("CURRENT_POSITION_TEXT")]
    [StringLength(255)]
    public string CurrentPositionText { get; set; }

    [Column("CURRENT_POSITION_GPS")]
    [StringLength(50)]
    public string CurrentPositionGps { get; set; }

    [Column("INIT_POSITION_GPS")]
    [StringLength(1000)]
    public string InitPositionGps { get; set; }

    [Column("INIT_POSITION_CODE")]
    [StringLength(255)]
    public string InitPositionCode { get; set; }
}
