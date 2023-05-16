using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DECISION_BONUS_DISCIPLINE_DETAIL")]
public partial class DecisionBonusDisciplineDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DECISION_NUM")]
    [StringLength(255)]
    public string DecisionNum { get; set; }

    [Column("EMPLOYEE_CODE")]
    [StringLength(255)]
    public string EmployeeCode { get; set; }

    [Column("REASON")]
    [StringLength(255)]
    public string Reason { get; set; }

    [Column("RESULT")]
    [StringLength(255)]
    public string Result { get; set; }

    [Column("MONEY")]
    [StringLength(255)]
    public string Money { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }
}
