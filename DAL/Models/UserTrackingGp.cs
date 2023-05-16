using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("USER_TRACKING_GPS")]
public partial class UserTrackingGp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string UserName { get; set; }

    [Column("TRACKING_DATE")]
    public DateTime? TrackingDate { get; set; }

    [Column("DATA_GPS")]
    [Unicode(false)]
    public string DataGps { get; set; }
}
