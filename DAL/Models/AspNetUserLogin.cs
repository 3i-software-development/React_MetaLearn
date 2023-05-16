using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[PrimaryKey("LoginProvider", "ProviderKey")]
[Table("ASP_NET_USER_LOGINS")]
[Index("UserId", Name = "IX_ASP_NET_USER_LOGINS_USER_ID")]
public partial class AspNetUserLogin
{
    [Key]
    [Column("LOGIN_PROVIDER")]
    public string LoginProvider { get; set; }

    [Key]
    [Column("PROVIDER_KEY")]
    public string ProviderKey { get; set; }

    [Column("PROVIDER_DISPLAY_NAME")]
    public string ProviderDisplayName { get; set; }

    [Required]
    [Column("USER_ID")]
    public string UserId { get; set; }
}
