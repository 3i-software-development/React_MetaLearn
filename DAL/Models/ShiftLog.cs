using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SHIFT_LOG")]
public partial class ShiftLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SHIFT_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ShiftCode { get; set; }

    [Column("CHKIN_TIME")]
    public DateTime? ChkinTime { get; set; }

    [Column("CHKIN_LOCATION_TXT")]
    public string ChkinLocationTxt { get; set; }

    [Column("CHKIN_LOCATION_GPS")]
    [StringLength(50)]
    [Unicode(false)]
    public string ChkinLocationGps { get; set; }

    [Column("CHKIN_PIC_REALTIME")]
    [StringLength(255)]
    [Unicode(false)]
    public string ChkinPicRealtime { get; set; }

    [Column("IS_CHKIN_REALTIME")]
    public bool? IsChkinRealtime { get; set; }

    [Column("CHKOUT_TIME")]
    public DateTime? ChkoutTime { get; set; }

    [Column("CHKOUT_LOCATION_TXT")]
    [StringLength(255)]
    public string ChkoutLocationTxt { get; set; }

    [Column("CHKOUT_LOCATION_GPS")]
    [StringLength(50)]
    [Unicode(false)]
    public string ChkoutLocationGps { get; set; }

    [Column("CHKOUT_PIC_REALTIME")]
    [StringLength(255)]
    [Unicode(false)]
    public string ChkoutPicRealtime { get; set; }

    [Column("IS_CHKOUT_READTIME")]
    public bool? IsChkoutReadtime { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    [StringLength(1)]
    [Unicode(false)]
    public string Flag { get; set; }

    [Column("FROM_DEVICE")]
    [StringLength(50)]
    [Unicode(false)]
    public string FromDevice { get; set; }

    [Column("IP")]
    [StringLength(100)]
    [Unicode(false)]
    public string Ip { get; set; }

    [Column("IMEI")]
    [StringLength(100)]
    [Unicode(false)]
    public string Imei { get; set; }
}
