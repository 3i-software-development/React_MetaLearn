using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("NOTIFICATION_OBJECT")]
public partial class NotificationObject
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    public string ObjType { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(255)]
    public string ObjCode { get; set; }

    [Column("IS_VIEWED")]
    public bool? IsViewed { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("LIST_USER")]
    [StringLength(1000)]
    public string ListUser { get; set; }
}
