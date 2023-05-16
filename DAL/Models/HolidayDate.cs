using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HOLIDAY_DATE")]
public partial class HolidayDate
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CALENDAR_DAY")]
    public DateTime CalendarDay { get; set; }

    [Column("LUNAR_DAY")]
    public DateTime LunarDay { get; set; }

    [Column("DAY_OF_WEEK")]
    public int DayOfWeek { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

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

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
