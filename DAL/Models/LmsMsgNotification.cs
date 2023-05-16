using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_MSG_NOTIFICATION")]
public partial class LmsMsgNotification
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("MSG_CONTENT")]
    public string MsgContent { get; set; }

    [Column("MSG_TYPE")]
    [StringLength(100)]
    public string MsgType { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
