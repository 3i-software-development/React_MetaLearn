using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_TEAM")]
public partial class ProjectTeam
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProjectCode { get; set; }

    [Column("TEAM_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TeamCode { get; set; }
}
