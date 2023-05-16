using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTACT")]
public partial class Contact
{
    /// <summary>
    /// Contact Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Contact Name
    /// </summary>
    [Column("CONTACT_NAME")]
    [StringLength(50)]
    public string ContactName { get; set; }

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
    /// Mobile Phone
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
    /// Email
    /// </summary>
    [Column("EMAIL")]
    [StringLength(100)]
    public string Email { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    /// <summary>
    /// User Id
    /// </summary>
    [Column("USER_ID")]
    public int? UserId { get; set; }

    /// <summary>
    /// Create time
    /// </summary>
    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// Update time
    /// </summary>
    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// Facebook
    /// </summary>
    [Column("FACEBOOK")]
    [StringLength(200)]
    public string Facebook { get; set; }

    /// <summary>
    /// Google Plus
    /// </summary>
    [Column("GOOGLE_PLUS")]
    [StringLength(200)]
    public string GooglePlus { get; set; }

    /// <summary>
    /// Skype
    /// </summary>
    [Column("SKYPE")]
    [StringLength(200)]
    public string Skype { get; set; }

    /// <summary>
    /// Twitter
    /// </summary>
    [Column("TWITTER")]
    [StringLength(200)]
    public string Twitter { get; set; }

    /// <summary>
    /// Image
    /// </summary>
    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    /// <summary>
    /// Customer Code
    /// </summary>
    [Column("CUS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CusCode { get; set; }

    /// <summary>
    /// Supplier Code
    /// </summary>
    [Column("SUPP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string SuppCode { get; set; }

    /// <summary>
    /// Flag
    /// </summary>
    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("TITLE")]
    [StringLength(1000)]
    public string Title { get; set; }

    [Column("IN_CHARGE_OF")]
    [StringLength(1000)]
    public string InChargeOf { get; set; }

    [Required]
    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
