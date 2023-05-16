using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SUPPLIER")]
public partial class Supplier
{
    /// <summary>
    /// Supplier Id
    /// </summary>
    [Key]
    [Column("SUP_ID")]
    public int SupId { get; set; }

    /// <summary>
    /// Supplier Code
    /// </summary>
    [Column("SUP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string SupCode { get; set; }

    /// <summary>
    /// Supplier Name
    /// </summary>
    [Column("SUP_NAME")]
    [StringLength(255)]
    public string SupName { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    /// <summary>
    /// Telephone
    /// </summary>
    [Column("TELEPHONE")]
    [StringLength(100)]
    public string Telephone { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    [Column("MOBILE")]
    [StringLength(100)]
    public string Mobile { get; set; }

    /// <summary>
    /// Tax Code
    /// </summary>
    [Column("TAX_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string TaxCode { get; set; }

    /// <summary>
    /// Supplier Type
    /// </summary>
    [Column("LOT_NAME")]
    [StringLength(50)]
    public string LotName { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    /// <summary>
    /// UserId
    /// </summary>
    [Column("USER_ID")]
    public int? UserId { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [Column("EMAIL")]
    [StringLength(100)]
    public string Email { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    [Column("WEBSITE")]
    [StringLength(100)]
    public string Website { get; set; }

    /// <summary>
    /// Supplier Group
    /// </summary>
    [Column("SUP_GROUP")]
    [StringLength(50)]
    public string SupGroup { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    [Column("DESCRIPTION")]
    public string Description { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    [Column("FAX")]
    [StringLength(100)]
    [Unicode(false)]
    public string Fax { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("GOOGLE_MAP")]
    [StringLength(500)]
    public string GoogleMap { get; set; }

    [Column("IDENTIFICATION")]
    [StringLength(50)]
    public string Identification { get; set; }

    [Column("ADDRESS_BANK")]
    [StringLength(255)]
    public string AddressBank { get; set; }

    [Column("ACCOUNT_BANK")]
    [StringLength(255)]
    public string AccountBank { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CUS_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CusType { get; set; }

    [Column("AREA")]
    [StringLength(255)]
    public string Area { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    public string Group { get; set; }

    [Column("ROLE")]
    [StringLength(255)]
    public string Role { get; set; }

    [Column("ICON_LEVEL")]
    [StringLength(255)]
    [Unicode(false)]
    public string IconLevel { get; set; }

    [Column("LIST_USER_VIEW")]
    [Unicode(false)]
    public string ListUserView { get; set; }
}
