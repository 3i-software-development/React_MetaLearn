using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_PEOPLE_TAGS")]
public partial class ContractPeopleTag
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CONTRACT_PEOPLE_TAG_ID")]
    public int ContractPeopleTagId { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    public string ContractCode { get; set; }

    [Column("ASSIGNER")]
    public string Assigner { get; set; }

    [Column("REQUEST_TIME")]
    public DateTime? RequestTime { get; set; }

    [Column("CONFIRM")]
    [StringLength(100)]
    public string Confirm { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("TAGS_TYPE")]
    [StringLength(50)]
    public string TagsType { get; set; }

    [Column("FLAGS")]
    public bool? Flags { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
