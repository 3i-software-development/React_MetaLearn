using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CUSTOMER_APPOINTMENT")]
public partial class CustomerAppointment
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CUSTOMER_CODE")]
    [StringLength(100)]
    public string CustomerCode { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("TAGS")]
    [StringLength(50)]
    public string Tags { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }

    [Column("LOCATION")]
    [StringLength(255)]
    public string Location { get; set; }

    [Column("REPEAT_TYPE")]
    [StringLength(255)]
    public string RepeatType { get; set; }

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
