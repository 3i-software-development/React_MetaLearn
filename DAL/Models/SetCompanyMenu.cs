using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SET_COMPANY_MENU")]
public partial class SetCompanyMenu
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("MENU_CAPTION")]
    [StringLength(255)]
    [Unicode(false)]
    public string MenuCaption { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("MENU_PARENT")]
    [StringLength(255)]
    [Unicode(false)]
    public string MenuParent { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Required]
    [Column("ACTION")]
    [StringLength(255)]
    public string Action { get; set; }

    [Required]
    [Column("PIN")]
    [StringLength(20)]
    [Unicode(false)]
    public string Pin { get; set; }

    [Column("PRIORITY")]
    public int Priority { get; set; }

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
