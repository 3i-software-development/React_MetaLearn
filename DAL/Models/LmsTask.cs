using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_TASK")]
[Index("ListCode", "IsDeleted", Name = "INDEX_GET_CARD_APP_LMS")]
public partial class LmsTask
{
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("LMS_TASK_CODE")]
    [StringLength(100)]
    public string LmsTaskCode { get; set; }

    [Column("LMS_TASK_NAME")]
    [StringLength(255)]
    public string LmsTaskName { get; set; }

    [Column("LIST_CODE")]
    [StringLength(100)]
    public string ListCode { get; set; }

    [Column("BEGIN_TIME")]
    public DateTime BeginTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("BACKGROUND_COLOR")]
    [StringLength(255)]
    public string BackgroundColor { get; set; }

    [Column("BACKGROUND_IMAGE")]
    [StringLength(255)]
    public string BackgroundImage { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("LOCK_SHARE")]
    public string LockShare { get; set; }

    [Column("LMS_TASK_TYPE")]
    [StringLength(255)]
    public string LmsTaskType { get; set; }

    [Column("LMS_TASK_NEXT")]
    public string LmsTaskNext { get; set; }

    [Column("LMS_USER_LIST")]
    public string LmsUserList { get; set; }

    [Column("LMS_ITEM_LIST")]
    public string LmsItemList { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("COUNT_ITEM_LIST")]
    public int? CountItemList { get; set; }
}
