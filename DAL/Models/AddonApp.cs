using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("ADDON_APP")]
public partial class AddonApp
{
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("APP_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppCode { get; set; }

    [Column("APP_TITLE")]
    [StringLength(255)]
    public string AppTitle { get; set; }

    /// <summary>
    /// Ngày xuất bản
    /// </summary>
    [Column("APP_DATE")]
    public DateTime? AppDate { get; set; }

    [Column("ICON")]
    [StringLength(255)]
    public string Icon { get; set; }

    [Column("LINK_CHPLAY")]
    [StringLength(50)]
    public string LinkChplay { get; set; }

    [Column("LINK_IOS")]
    [StringLength(50)]
    public string LinkIos { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

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

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
