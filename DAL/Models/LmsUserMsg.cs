using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_USER_MSG")]
public partial class LmsUserMsg
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("MSG_ID")]
    public int? MsgId { get; set; }

    [Column("USR_SEND")]
    [StringLength(100)]
    public string UsrSend { get; set; }

    [Column("USR_RECEIVER")]
    [StringLength(100)]
    public string UsrReceiver { get; set; }

    [Column("CONFIRM")]
    public bool? Confirm { get; set; }

    [Column("NOTE")]
    [StringLength(100)]
    public string Note { get; set; }

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
