using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_GROUP_USER")]
public partial class AdGroupUser
{
    [Key]
    [Column("GROUP_USER_CODE")]
    [StringLength(50)]
    public string GroupUserCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("PARENT_CODE")]
    [StringLength(50)]
    public string ParentCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(100)]
    public string Description { get; set; }

    [Column("UPDATED_DATE")]
    [Precision(6)]
    public DateTime? UpdatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(45)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    [Precision(6)]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column("IS_ENABLED")]
    public bool? IsEnabled { get; set; }

    [Column("GROUP_USER_ID")]
    public int GroupUserId { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
