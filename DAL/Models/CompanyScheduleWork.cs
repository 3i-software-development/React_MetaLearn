using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("COMPANY_SCHEDULE_WORK")]
public partial class CompanyScheduleWork
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserName { get; set; }

    [Column("FROM_MORNING")]
    public TimeSpan? FromMorning { get; set; }

    [Column("TO_MORNING")]
    public TimeSpan? ToMorning { get; set; }

    [Column("FROM_AFTERNOON")]
    public TimeSpan? FromAfternoon { get; set; }

    [Column("TO_AFTERNOON")]
    public TimeSpan? ToAfternoon { get; set; }

    [Column("FROM_EVENING")]
    public TimeSpan? FromEvening { get; set; }

    [Column("TO_EVENING")]
    public TimeSpan? ToEvening { get; set; }

    [Column("CREATED_BY")]
    [StringLength(7)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

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
