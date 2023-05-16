using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_REPO_CAT_FILE")]
public partial class EdmsRepoCatFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }

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
}
