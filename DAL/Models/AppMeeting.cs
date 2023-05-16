using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("APP_MEETING")]
public partial class AppMeeting
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ZOOM_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string ZoomId { get; set; }

    [Column("ZOOM_PASSWORK")]
    [StringLength(255)]
    [Unicode(false)]
    public string ZoomPasswork { get; set; }

    [Column("DISPLAY_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string DisplayName { get; set; }

    [Column("IMEI")]
    [StringLength(255)]
    [Unicode(false)]
    public string Imei { get; set; }
}
