using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ALLOWANCE_EMPLOYEE_ACCEPT")]
public partial class AllowanceEmployeeAccept
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EMPLOYEE_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string EmployeeId { get; set; }

    [Column("ALLOWANCE_CAT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AllowanceCatCode { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
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

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
