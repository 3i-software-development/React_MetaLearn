using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("HR_EMPLOYEE_DECISION")]
public partial class HrEmployeeDecision
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DECISION_CODE")]
    [StringLength(255)]
    public string DecisionCode { get; set; }

    [Column("DECISION_DATE")]
    public DateTime? DecisionDate { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 1- Chấm dứt hợp đồng
    /// 2- Điều động nhân sự
    /// 3- Chuyển phong ban nhân sự
    /// </summary>
    [Column("STYLE")]
    public int? Style { get; set; }

    [Column("DECISION_MAKING_DATE")]
    public DateTime? DecisionMakingDate { get; set; }
}
