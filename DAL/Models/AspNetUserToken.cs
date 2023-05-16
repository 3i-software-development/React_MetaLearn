using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[PrimaryKey("UserId", "LoginProvider", "Name")]
[Table("ASP_NET_USER_TOKENS")]
public partial class AspNetUserToken
{
    [Key]
    [Column("USER_ID")]
    public string UserId { get; set; }

    [Key]
    [Column("LOGIN_PROVIDER")]
    public string LoginProvider { get; set; }

    [Key]
    [Column("NAME")]
    public string Name { get; set; }

    [Column("VALUE")]
    public string Value { get; set; }
}
