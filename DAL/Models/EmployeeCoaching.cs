using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EMPLOYEE_COACHING")]
public partial class EmployeeCoaching
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("COACH_TYPE")]
    [StringLength(255)]
    public string CoachType { get; set; }

    [Column("COACH_ID")]
    public int? CoachId { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(255)]
    public string ItemCode { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }
}
