using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_CAT_REPO_SETTING")]
public partial class EdmsCatRepoSetting
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

    [Column("PATH")]
    [StringLength(255)]
    public string Path { get; set; }

    [Column("FOLDER_ID")]
    [StringLength(255)]
    public string FolderId { get; set; }

    [Column("FOLDER_NAME")]
    [StringLength(255)]
    public string FolderName { get; set; }
}
