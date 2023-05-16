using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("WORK_EXECUTIVE_OBJECTRELATIVE")]
public partial class WorkExecutiveObjectrelative
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LIST_CODE")]
    [StringLength(255)]
    public string ListCode { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("OBJECT_MODULE")]
    [StringLength(255)]
    public string ObjectModule { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

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

    [Column("FLAG")]
    public bool Flag { get; set; }
}
