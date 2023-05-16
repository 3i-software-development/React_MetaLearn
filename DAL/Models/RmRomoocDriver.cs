using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_ROMOOC_DRIVER")]
public partial class RmRomoocDriver
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTIVE")]
    public int? Active { get; set; }

    [Column("BALANCE_CREDIT")]
    public double? BalanceCredit { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    public string Email { get; set; }

    [Column("ID_FB")]
    [StringLength(50)]
    public string IdFb { get; set; }

    [Column("IDENTIFICATION")]
    [StringLength(255)]
    public string Identification { get; set; }

    [Column("IMAGE_CAR")]
    [StringLength(255)]
    public string ImageCar { get; set; }

    [Column("IS_BUSY")]
    public int? IsBusy { get; set; }

    [Column("LICENSE_CAR_IMAGE")]
    [StringLength(255)]
    public string LicenseCarImage { get; set; }

    [Column("LICENSE_PLATE")]
    [StringLength(50)]
    public string LicensePlate { get; set; }

    [Column("NAME")]
    [StringLength(150)]
    public string Name { get; set; }

    [Column("PASSWORD")]
    [StringLength(50)]
    public string Password { get; set; }

    [Column("PHONE")]
    [StringLength(15)]
    public string Phone { get; set; }

    [Column("PROFILE_PICTURE")]
    [StringLength(255)]
    public string ProfilePicture { get; set; }

    [Column("TAXY_TYPE")]
    [StringLength(255)]
    public string TaxyType { get; set; }

    [Column("TYPE_DRIVER")]
    public int? TypeDriver { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    public string Group { get; set; }

    [Column("UPDATED_BY")]
    public int? UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("USERNAME")]
    [StringLength(50)]
    public string Username { get; set; }

    [Column("IS_ONLINE")]
    public int IsOnline { get; set; }

    [Column("TYPE_CAR_YEAR")]
    [StringLength(50)]
    public string TypeCarYear { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("EMEI")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emei { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("BRAND")]
    [StringLength(255)]
    public string Brand { get; set; }

    [Column("POLYLINE")]
    [StringLength(2000)]
    public string Polyline { get; set; }

    [Column("VIRUAL_INTIARY")]
    [StringLength(4000)]
    public string VirualIntiary { get; set; }

    [Column("START_NAME")]
    [StringLength(255)]
    public string StartName { get; set; }

    [Column("END_NAME")]
    [StringLength(255)]
    public string EndName { get; set; }

    [Column("START_NAME_GPS")]
    [StringLength(255)]
    public string StartNameGps { get; set; }

    [Column("END_NAME_GPS")]
    [StringLength(255)]
    public string EndNameGps { get; set; }

    [Column("POSITION_GPS")]
    [StringLength(1000)]
    public string PositionGps { get; set; }

    [Column("POSITION_TEXT")]
    [StringLength(500)]
    public string PositionText { get; set; }

    [Column("POSITION_TIME")]
    public DateTime? PositionTime { get; set; }

    [Column("TYPE")]
    [StringLength(1)]
    public string Type { get; set; }

    [Column("CURRENT_CHANNEL")]
    [StringLength(20)]
    [Unicode(false)]
    public string CurrentChannel { get; set; }

    [Column("REMOOC_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string RemoocCode { get; set; }

    [Column("TRACTOR_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TractorCode { get; set; }
}
