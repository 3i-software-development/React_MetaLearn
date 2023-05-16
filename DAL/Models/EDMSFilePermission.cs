using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_FILE_PERMISSION")]
public partial class EdmsFilePermission
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("PERMISSION_ID")]
    public int PermissionId { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    public string FileCode { get; set; }

    [Column("PERMISSION")]
    [StringLength(100)]
    public string Permission { get; set; }

    [Column("MEMBER_ID")]
    public string MemberId { get; set; }

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
