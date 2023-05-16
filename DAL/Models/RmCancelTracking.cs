using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_CANCEL_TRACKING")]
public partial class RmCancelTracking
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(100)]
    [Unicode(false)]
    public string LocationGps { get; set; }

    [Column("LOCATION_TEXT")]
    [StringLength(100)]
    public string LocationText { get; set; }

    [Column("REASON_CANCEL")]
    [StringLength(100)]
    public string ReasonCancel { get; set; }

    [Column("TRIP_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string TripCode { get; set; }

    [Column("CREATE_DATE", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("PARKING_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ParkingCode { get; set; }

    [Column("CREATE_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string CreateBy { get; set; }

    [Column("NOTE")]
    [StringLength(300)]
    public string Note { get; set; }
}
