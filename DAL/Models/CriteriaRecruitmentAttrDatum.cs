using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CRITERIA_RECRUITMENT_ATTR_DATA")]
public partial class CriteriaRecruitmentAttrDatum
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("PLAN_NUMBER")]
    [StringLength(255)]
    public string PlanNumber { get; set; }

    [Column("ATTR_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AttrCode { get; set; }

    [Column("ATTR_VALUE")]
    [StringLength(255)]
    public string AttrValue { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }
}
