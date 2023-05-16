using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_ITEM_ASSIGN_STAFF")]
public partial class WorkItemAssignStaff
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("OBJECT_G_D")]
    [StringLength(255)]
    public string ObjectGD { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("CHECK_ITEM")]
    [StringLength(255)]
    public string CheckItem { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("CHECK_LIST_CODE")]
    [StringLength(255)]
    public string CheckListCode { get; set; }

    [Column("ESTIMATE_TIME")]
    [StringLength(255)]
    public string EstimateTime { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }
}
