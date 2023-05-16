using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("ADDON_APP_SERVER")]
public partial class AddonAppServer
{
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("APP_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppCode { get; set; }

    [Column("APP_VENDOR_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppVendorCode { get; set; }

    [Column("SERVER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ServerCode { get; set; }

    [Column("SERVER_ADDRESS")]
    [StringLength(255)]
    public string ServerAddress { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    public string QrCode { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("LOGO")]
    [StringLength(255)]
    public string Logo { get; set; }

    [Column("BACKGROUND")]
    [StringLength(255)]
    public string Background { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
