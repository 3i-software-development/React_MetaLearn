using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_USER_DEPARTMENT")]
public partial class AdUserDepartment
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(50)]
    public string DepartmentCode { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("ROLE_ID")]
    [StringLength(50)]
    public string RoleId { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("BRANCH")]
    [StringLength(50)]
    [Unicode(false)]
    public string Branch { get; set; }

    [Column("IS_MAIN")]
    public bool? IsMain { get; set; }
}
