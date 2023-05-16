using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("AD_LANGUAGE_TEXT")]
public partial class AdLanguageText
{
    [Column("LANGUAGE_TEXT_ID")]
    public int LanguageTextId { get; set; }

    [Column("LANGUAGE_ID")]
    public int LanguageId { get; set; }

    [Column("CAPTION")]
    [StringLength(500)]
    public string Caption { get; set; }

    [Column("VALUE")]
    public string Value { get; set; }

    [Column("GROUP_CAPTION")]
    [StringLength(20)]
    public string GroupCaption { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_DATE")]
    public DateTime? DeletedDate { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
