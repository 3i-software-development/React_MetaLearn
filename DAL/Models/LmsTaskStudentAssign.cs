using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LMS_TASK_STUDENT_ASSIGN")]
public partial class LmsTaskStudentAssign
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_ID")]
    [StringLength(100)]
    [Unicode(false)]
    public string UserId { get; set; }

    [Column("LMS_TASK_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string LmsTaskCode { get; set; }

    [Column("ACTION")]
    [StringLength(100)]
    [Unicode(false)]
    public string Action { get; set; }

    [Column("IS_CHECK")]
    public bool IsCheck { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("FROM_DEVICE")]
    [StringLength(255)]
    public string FromDevice { get; set; }

    [Column("ID_OBJECT")]
    [StringLength(255)]
    public string IdObject { get; set; }

    [Column("CHANGE_DETAILS")]
    public string ChangeDetails { get; set; }

    [Column("LOG")]
    public string Log { get; set; }
}
