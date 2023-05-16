using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SESSION_WORK")]
public partial class SessionWork
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ITEM")]
    [StringLength(255)]
    public string Item { get; set; }

    [Column("ITEM_TYPE")]
    [StringLength(255)]
    public string ItemType { get; set; }

    [Column("SESSION")]
    [StringLength(255)]
    public string Session { get; set; }

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

    [Column("DESC")]
    public string Desc { get; set; }
}
