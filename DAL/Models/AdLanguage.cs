using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("AD_LANGUAGE")]
public partial class AdLanguage
{
    [Column("LANGUAGE_ID")]
    public int LanguageId { get; set; }

    [Column("CULTURE")]
    [StringLength(10)]
    public string Culture { get; set; }

    [Column("DISPLAY_NAME")]
    [StringLength(256)]
    public string DisplayName { get; set; }

    [Column("ICON")]
    [StringLength(128)]
    public string Icon { get; set; }

    [Column("ORDERING")]
    public int Ordering { get; set; }

    [Column("IS_ENABLED")]
    public bool IsEnabled { get; set; }

    [Column("IS_DEFAULT")]
    public bool? IsDefault { get; set; }

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
