using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("TOKEN_MANAGER")]
public partial class TokenManager
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SERVICE_TYPE")]
    [StringLength(50)]
    public string ServiceType { get; set; }

    [Column("ACCOUNT_CODE")]
    [StringLength(255)]
    public string AccountCode { get; set; }

    [Column("ACCOUNT_NAME")]
    [StringLength(255)]
    public string AccountName { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    public string Email { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("ACCOUNT_NUMBER")]
    [StringLength(250)]
    [Unicode(false)]
    public string AccountNumber { get; set; }

    [Column("KEY")]
    [StringLength(255)]
    public string Key { get; set; }

    [Column("API_SECRET")]
    [StringLength(255)]
    [Unicode(false)]
    public string ApiSecret { get; set; }

    [Column("TOKEN")]
    [Unicode(false)]
    public string Token { get; set; }

    [Column("SDK_KEY")]
    [StringLength(255)]
    [Unicode(false)]
    public string SdkKey { get; set; }

    [Column("SDK_SECRET")]
    [StringLength(255)]
    [Unicode(false)]
    public string SdkSecret { get; set; }

    [Column("CREDENTIALS_JSON")]
    public string CredentialsJson { get; set; }

    [Column("REFRESH_TOKEN")]
    public string RefreshToken { get; set; }

    [Column("ACCOUNT_ROLE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AccountRole { get; set; }

    [Column("LIMIT")]
    public int? Limit { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("HOST_CLAIM_CODE")]
    [StringLength(255)]
    public string HostClaimCode { get; set; }

    [Column("IS_DEFAULT")]
    public bool? IsDefault { get; set; }

    [Column("DEFAULT_FOLDER_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string DefaultFolderId { get; set; }
}
