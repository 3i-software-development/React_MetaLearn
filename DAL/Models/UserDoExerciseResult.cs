using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("USER_DO_EXERCISE_RESULT")]
public partial class UserDoExerciseResult
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("QUIZ_CODE")]
    [StringLength(255)]
    public string QuizCode { get; set; }

    [Column("USER_CHOOSE")]
    [StringLength(255)]
    public string UserChoose { get; set; }

    [Column("RESULT")]
    public bool? Result { get; set; }

    [Column("SESSION_CODE")]
    [StringLength(255)]
    public string SessionCode { get; set; }

    [Column("TYPE_TRAINING")]
    [StringLength(255)]
    public string TypeTraining { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }
}
