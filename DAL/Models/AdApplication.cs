using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("AD_APPLICATION")]
public partial class AdApplication
{
    [Required]
    [Column("APPLICATION_CODE")]
    [StringLength(50)]
    public string ApplicationCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("APP_URL")]
    [StringLength(300)]
    public string AppUrl { get; set; }

    [Column("ICON")]
    [StringLength(300)]
    public string Icon { get; set; }

    [Column("STATUS")]
    public int Status { get; set; }

    [Column("ORD")]
    public int? Ord { get; set; }

    [Column("AUTHENTICATION_SCHEME")]
    [StringLength(255)]
    public string AuthenticationScheme { get; set; }

    [Column("AUTHORITY")]
    [StringLength(255)]
    public string Authority { get; set; }

    [Column("CLIENT_ID")]
    [StringLength(255)]
    public string ClientId { get; set; }

    [Column("CLIENT_SECRET")]
    [StringLength(255)]
    public string ClientSecret { get; set; }

    [Column("NAME_CLAIM_TYPE")]
    [StringLength(255)]
    public string NameClaimType { get; set; }

    [Column("REQUIRE_HTTPS")]
    public int? RequireHttps { get; set; }

    [Column("RESPONSE_TYPE")]
    [StringLength(255)]
    public string ResponseType { get; set; }

    [Column("ROLE_CLAIM_TYPE")]
    [StringLength(255)]
    public string RoleClaimType { get; set; }

    [Column("SCOPE")]
    [StringLength(255)]
    public string Scope { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("APPLICATION_ID")]
    public int ApplicationId { get; set; }
}
