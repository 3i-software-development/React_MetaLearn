using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_WORK_CHECK")]
public partial class VcWorkCheck
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CHECKIN_TIME")]
    public DateTime? CheckinTime { get; set; }

    [Column("CHECKIN")]
    public bool? Checkin { get; set; }

    [Column("CHECKOUT")]
    public bool? Checkout { get; set; }

    [Column("CHECKOUT_TIME")]
    public DateTime? CheckoutTime { get; set; }

    [Column("CARE_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CareCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("REVIEW")]
    [StringLength(255)]
    public string Review { get; set; }

    [Column("IDEA")]
    [StringLength(255)]
    public string Idea { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    [Column("CHECKIN_GPS")]
    [StringLength(100)]
    [Unicode(false)]
    public string CheckinGps { get; set; }

    [Column("CHECKOUT_GPS")]
    [StringLength(100)]
    [Unicode(false)]
    public string CheckoutGps { get; set; }

    [Column("USER_NAME")]
    [StringLength(50)]
    public string UserName { get; set; }

    [Column("IMEI")]
    [StringLength(255)]
    [Unicode(false)]
    public string Imei { get; set; }

    [Column("IMAGE_PATH")]
    [StringLength(255)]
    public string ImagePath { get; set; }

    [Column("COUNT")]
    public int Count { get; set; }

    [Column("CHECKOUT_OUT_DISTANCE")]
    public bool? CheckoutOutDistance { get; set; }
}
