using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("P_AREA_CATEGORY_STORE")]
public partial class PAreaCategoryStore
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("P_AREA_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string PAreaCode { get; set; }

    [Column("P_AREA_PARENT")]
    [StringLength(50)]
    [Unicode(false)]
    public string PAreaParent { get; set; }

    [Column("P_AREA_TYPE")]
    [StringLength(255)]
    public string PAreaType { get; set; }

    [Column("P_AREA_DESCRIPTION")]
    public string PAreaDescription { get; set; }

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
    public bool? IsDeleted { get; set; }
}
