using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CUSTOMER")]
public partial class Customer
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CUS_ID")]
    public int CusId { get; set; }

    /// <summary>
    /// Customer Code
    /// </summary>
    [Column("CUS_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CusCode { get; set; }

    /// <summary>
    /// Customer Name
    /// </summary>
    [Column("CUS_NAME")]
    [StringLength(255)]
    public string CusName { get; set; }

    /// <summary>
    /// Birthday
    /// </summary>
    [Column("LOT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string LotName { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [Column("EMAIL")]
    [StringLength(200)]
    public string Email { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    [Column("ADDRESS")]
    [StringLength(500)]
    public string Address { get; set; }

    /// <summary>
    /// Telephone
    /// </summary>
    [Column("TELEPHONE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Telephone { get; set; }

    /// <summary>
    /// MobilePhone
    /// </summary>
    [Column("MOBILE_PHONE")]
    [StringLength(100)]
    [Unicode(false)]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    [Column("FAX")]
    [StringLength(100)]
    [Unicode(false)]
    public string Fax { get; set; }

    /// <summary>
    /// Customer Group
    /// </summary>
    [Column("CUS_GROUP")]
    [StringLength(100)]
    public string CusGroup { get; set; }

    /// <summary>
    /// Activity Status
    /// </summary>
    [Column("ACTIVITY_STATUS")]
    [StringLength(100)]
    public string ActivityStatus { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    [Column("DESCRIPTION")]
    public string Description { get; set; }

    /// <summary>
    /// Flag
    /// </summary>
    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("GOOGLE_MAP")]
    [StringLength(500)]
    public string GoogleMap { get; set; }

    [Column("ACCOUNT_BANK")]
    [StringLength(100)]
    [Unicode(false)]
    public string AccountBank { get; set; }

    [Column("BANK_NAME")]
    [StringLength(255)]
    public string BankName { get; set; }

    [Column("IDENTIFICATION")]
    [StringLength(255)]
    public string Identification { get; set; }

    [Column("ADDRESS_BANK")]
    [StringLength(255)]
    public string AddressBank { get; set; }

    [Column("TAX_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TaxCode { get; set; }

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

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("AREA")]
    [StringLength(255)]
    public string Area { get; set; }

    [Column("GROUP")]
    [StringLength(50)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("ROLE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Role { get; set; }

    [Column("IN_AGENT")]
    [StringLength(255)]
    [Unicode(false)]
    public string InAgent { get; set; }

    [Column("HAS_STOCK")]
    public bool? HasStock { get; set; }

    [Column("TOTAL_STOCK")]
    [StringLength(20)]
    [Unicode(false)]
    public string TotalStock { get; set; }

    [Column("RESOURCE")]
    [StringLength(255)]
    public string Resource { get; set; }

    [Column("LOGO")]
    [StringLength(255)]
    public string Logo { get; set; }

    [Column("TRANSPORT")]
    [StringLength(255)]
    public string Transport { get; set; }

    [Column("SURROGATE")]
    [StringLength(255)]
    public string Surrogate { get; set; }

    /// <summary>
    /// ICON LEVEL CODE
    /// </summary>
    [Column("ICON_LEVEL")]
    [StringLength(255)]
    [Unicode(false)]
    public string IconLevel { get; set; }

    [Column("ZIP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ZipCode { get; set; }

    /// <summary>
    /// Người phụ trách
    /// </summary>
    [Column("PERSON_IN_CHARGE")]
    [StringLength(255)]
    public string PersonInCharge { get; set; }

    [Column("LIST_USER_VIEW")]
    [Unicode(false)]
    public string ListUserView { get; set; }
}
