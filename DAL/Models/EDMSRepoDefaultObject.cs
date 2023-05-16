using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_REPO_DEFAULT_OBJECT")]
public partial class EdmsRepoDefaultObject
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("REPOS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ReposCode { get; set; }

    [Column("CAT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CatCode { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjectCode { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjectType { get; set; }

    [Column("PATH")]
    [StringLength(255)]
    public string Path { get; set; }

    [Column("FOLDER_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string FolderId { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("CAT_REPO_SETTING_ID")]
    public int? CatRepoSettingId { get; set; }
}
