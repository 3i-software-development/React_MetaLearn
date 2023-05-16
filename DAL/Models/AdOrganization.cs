using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("AD_ORGANIZATION")]
public partial class AdOrganization
{
    [Column("ORG_ID")]
    public int OrgId { get; set; }

    [Required]
    [Column("ORG_ADDON_CODE")]
    [StringLength(50)]
    public string OrgAddonCode { get; set; }

    [Column("ORG_GROUP")]
    public int? OrgGroup { get; set; }

    [Column("ORG_CODE")]
    [StringLength(50)]
    public string OrgCode { get; set; }

    [Column("ORG_NAME")]
    [StringLength(500)]
    public string OrgName { get; set; }

    [Column("ORG_ORD", TypeName = "decimal(10, 0)")]
    public decimal? OrgOrd { get; set; }

    [Column("ORG_PARENT_CODE")]
    [StringLength(50)]
    public string OrgParentCode { get; set; }

    [Column("ORG_UPDATE_TIME")]
    [StringLength(50)]
    public string OrgUpdateTime { get; set; }

    [Column("COMPANY")]
    [StringLength(255)]
    public string Company { get; set; }

    [Column("COUNTRY")]
    [StringLength(255)]
    public string Country { get; set; }

    [Column("STATE")]
    [StringLength(255)]
    public string State { get; set; }

    [Column("HIERARCHY_CODE")]
    [StringLength(255)]
    public string HierarchyCode { get; set; }

    [Column("DIVISION")]
    [StringLength(255)]
    public string Division { get; set; }

    [Column("IS_ENABLED")]
    public bool IsEnabled { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(255)]
    public string DepartmentCode { get; set; }
}
