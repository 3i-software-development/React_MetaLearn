using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("NOTIFICATION_MANAGER")]
public partial class NotificationManager
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NOTIFY_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string NotifyCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }

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
