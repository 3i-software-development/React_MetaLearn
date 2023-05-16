using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HR_ROMOOC_DRIVER")]
public partial class HrRomoocDriver
{
    [Key]
    public int Id { get; set; }

    public int? Active { get; set; }

    [Column("Balance_Credit")]
    public double? BalanceCredit { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string Email { get; set; }

    [Column("Id_Fb")]
    [StringLength(50)]
    public string IdFb { get; set; }

    [Column("Identification_image")]
    [StringLength(255)]
    public string IdentificationImage { get; set; }

    [Column("Image_car")]
    [StringLength(255)]
    public string ImageCar { get; set; }

    [Column("Is_busy")]
    public int? IsBusy { get; set; }

    [Column("License_car_image")]
    [StringLength(255)]
    public string LicenseCarImage { get; set; }

    [Column("License_plate")]
    [StringLength(50)]
    public string LicensePlate { get; set; }

    [StringLength(150)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Password { get; set; }

    [StringLength(15)]
    public string Phone { get; set; }

    [Column("Profile_Picture")]
    [StringLength(255)]
    public string ProfilePicture { get; set; }

    [Column("Taxy_type")]
    [StringLength(255)]
    public string TaxyType { get; set; }

    [Column("Type_Driver")]
    public int? TypeDriver { get; set; }

    [Column("Type_Seat")]
    public int? TypeSeat { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    [StringLength(50)]
    public string Username { get; set; }

    [Column("is_Online")]
    public int IsOnline { get; set; }

    [Column("type_car_year")]
    [StringLength(50)]
    public string TypeCarYear { get; set; }

    [Column("company_code")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("emei")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emei { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [StringLength(255)]
    public string Brand { get; set; }

    [StringLength(2000)]
    public string Polyline { get; set; }

    [Column("virual_intiary")]
    [StringLength(4000)]
    public string VirualIntiary { get; set; }

    [Column("Start_name")]
    [StringLength(255)]
    public string StartName { get; set; }

    [Column("End_name")]
    [StringLength(255)]
    public string EndName { get; set; }

    [Column("Start_Name_GPS")]
    [StringLength(255)]
    public string StartNameGps { get; set; }

    [Column("End_Name_GPS")]
    [StringLength(255)]
    public string EndNameGps { get; set; }
}
