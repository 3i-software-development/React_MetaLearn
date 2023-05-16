using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_MEMBER")]
public partial class ProjectMember
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    public string ProjectCode { get; set; }

    [Column("MEMBER_CODE")]
    [StringLength(100)]
    public string MemberCode { get; set; }

    [Column("POSITION")]
    [StringLength(50)]
    public string Position { get; set; }

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

    [Column("FLAG_DELETED")]
    public bool FlagDeleted { get; set; }
}
