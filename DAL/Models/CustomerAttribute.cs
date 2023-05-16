using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CUSTOMER_ATTRIBUTE")]
public partial class CustomerAttribute
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("VALUE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Value { get; set; }

    [Column("LABEL")]
    [StringLength(50)]
    [Unicode(false)]
    public string Label { get; set; }

    [Column("CUS_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string CusId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
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
