using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_USER_EVENT")]
public partial class WorkUserEvent
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EVENT_CAT_CODE")]
    [StringLength(255)]
    public string EventCatCode { get; set; }

    [Column("MEMBER_ID")]
    [StringLength(255)]
    public string MemberId { get; set; }

    [Column("PRESENT")]
    [StringLength(50)]
    public string Present { get; set; }

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

    [Column("FLAG")]
    public bool Flag { get; set; }
}
