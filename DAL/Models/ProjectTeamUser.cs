using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_TEAM_USER")]
public partial class ProjectTeamUser
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TEAM_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TeamCode { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string UserId { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }

    [Column("TABLE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Table { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
