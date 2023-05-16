using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CATEGORY_CAREER")]
public partial class CategoryCareer
{
    [Key]
    public int Id { get; set; }

    [Column("CAREER_CODE")]
    [StringLength(255)]
    public string CareerCode { get; set; }

    [Column("CAREER_NAME")]
    [StringLength(255)]
    public string CareerName { get; set; }

    [Column("CAREER_GROUP")]
    [StringLength(255)]
    public string CareerGroup { get; set; }

    [Column("CAREER_TYPE")]
    [StringLength(255)]
    public string CareerType { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("PAY_GRADES_CODE")]
    [StringLength(255)]
    public string PayGradesCode { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }
}
