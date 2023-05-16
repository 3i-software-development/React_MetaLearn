using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_CLASS")]
public partial class LmsClass
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CLASS_CODE")]
    [StringLength(255)]
    public string ClassCode { get; set; }

    [Column("CLASS_NAME")]
    [StringLength(255)]
    public string ClassName { get; set; }

    [Column("LMS_TASK_CODE")]
    [StringLength(255)]
    public string LmsTaskCode { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("NOTED")]
    [StringLength(1000)]
    public string Noted { get; set; }

    [Column("MANAGER_TEACHER")]
    [StringLength(255)]
    public string ManagerTeacher { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }
}
