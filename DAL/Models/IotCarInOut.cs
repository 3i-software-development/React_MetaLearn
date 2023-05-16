using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("IOT_CAR_IN_OUT")]
public partial class IotCarInOut
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LICENSE_PLATE")]
    [StringLength(255)]
    [Unicode(false)]
    public string LicensePlate { get; set; }

    [Column("DATE_TIME")]
    public DateTime? DateTime { get; set; }

    [Column("ACTIVE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Active { get; set; }

    [Column("DRIVER")]
    [StringLength(255)]
    public string Driver { get; set; }

    [Column("IMG1")]
    [StringLength(255)]
    [Unicode(false)]
    public string Img1 { get; set; }

    [Column("IMG2")]
    [StringLength(255)]
    [Unicode(false)]
    public string Img2 { get; set; }

    [Column("IMG3")]
    [StringLength(255)]
    [Unicode(false)]
    public string Img3 { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }
}
