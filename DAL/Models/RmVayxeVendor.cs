using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_VAYXE_VENDOR")]
public partial class RmVayxeVendor
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("VENDOR_CODE")]
    [StringLength(250)]
    public string VendorCode { get; set; }

    [Column("VENDOR_CONTACT")]
    [StringLength(250)]
    public string VendorContact { get; set; }

    [Column("VENDOR_NAME")]
    [StringLength(250)]
    public string VendorName { get; set; }

    [Column("VENDOR_LOGO")]
    [StringLength(250)]
    public string VendorLogo { get; set; }

    [Column("VENDOR_PHONE")]
    [StringLength(250)]
    public string VendorPhone { get; set; }

    [Column("VENDOR_TYPE")]
    public int? VendorType { get; set; }

    [Column("VENDOR_WEBSITE")]
    [StringLength(250)]
    public string VendorWebsite { get; set; }

    [Column("VENDOR_FB")]
    [StringLength(250)]
    public string VendorFb { get; set; }

    [Column("VENDOR_DESC")]
    [StringLength(2000)]
    public string VendorDesc { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("CREATE_BY")]
    public int? CreateBy { get; set; }

    [Column("UPDATE_BY")]
    public int? UpdateBy { get; set; }

    [Column("VENDOR_ADDRESS")]
    public string VendorAddress { get; set; }

    [Column("IS_DELETE")]
    public bool? IsDelete { get; set; }

    [Column("GEO_CODE")]
    [StringLength(255)]
    public string GeoCode { get; set; }
}
