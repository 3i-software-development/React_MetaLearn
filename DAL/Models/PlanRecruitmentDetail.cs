using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PLAN_RECRUITMENT_DETAIL")]
public partial class PlanRecruitmentDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PLAN_NUMBER")]
    [StringLength(255)]
    public string PlanNumber { get; set; }

    [Column("POSITION")]
    [StringLength(255)]
    public string Position { get; set; }

    [Column("AGE")]
    [StringLength(50)]
    public string Age { get; set; }

    [Column("GENDER")]
    [StringLength(255)]
    public string Gender { get; set; }

    [Column("LEVEL")]
    [StringLength(255)]
    public string Level { get; set; }

    [Column("SPECIALIZE")]
    [StringLength(255)]
    public string Specialize { get; set; }

    [Column("YEAR_OF_EXPERIENCE")]
    public int? YearOfExperience { get; set; }

    [Column("TIER")]
    [StringLength(255)]
    public string Tier { get; set; }

    [Column("LOCAL")]
    [StringLength(255)]
    public string Local { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

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
}
