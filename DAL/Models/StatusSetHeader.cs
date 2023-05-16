using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("STATUS_SET_HEADER")]
public partial class StatusSetHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string GroupCode { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(255)]
    public string GroupName { get; set; }

    [Column("GROUP_DESC")]
    [StringLength(255)]
    public string GroupDesc { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
