using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DASHBOARD_DATA_JSON_copy")]
public partial class DashboardDataJsonCopy
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectType { get; set; }

    [Column("DATA_JSON")]
    public string DataJson { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
