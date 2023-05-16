using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_TIME_OF_DOCUMENT_PRESERVATION")]
public partial class EdmsTimeOfDocumentPreservation
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Code { get; set; }

    [Required]
    [Column("TITLE")]
    [StringLength(500)]
    public string Title { get; set; }

    [Column("STORAGE_TIME_LIMIT")]
    public int StorageTimeLimit { get; set; }

    [Column("TYPE_LEVEL1")]
    [StringLength(500)]
    public string TypeLevel1 { get; set; }

    [Column("TYPE_LEVEL2")]
    [StringLength(255)]
    public string TypeLevel2 { get; set; }

    [Column("GROUP_LEVEL1")]
    [StringLength(255)]
    public string GroupLevel1 { get; set; }

    [Column("GROUP_LEVEL2")]
    [StringLength(255)]
    public string GroupLevel2 { get; set; }

    [Column("GROUP_LEVEL3")]
    [StringLength(255)]
    public string GroupLevel3 { get; set; }

    [Column("TITLE_FULL")]
    [StringLength(1500)]
    public string TitleFull { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Required]
    [Column("CODE_TABLE_COMMON")]
    [StringLength(100)]
    public string CodeTableCommon { get; set; }
}
