using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ATTR_SETUP")]
public partial class AttrSetup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ATTR_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AttrCode { get; set; }

    [Column("ATTR_NAME")]
    [StringLength(255)]
    public string AttrName { get; set; }

    [Column("ATTR_GROUP")]
    [StringLength(255)]
    public string AttrGroup { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("ATTR_DATA_TYPE")]
    [StringLength(100)]
    public string AttrDataType { get; set; }

    [Column("ATTR_UNIT")]
    [StringLength(100)]
    public string AttrUnit { get; set; }

    [Column("ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ActCode { get; set; }

    [Column("FILE_PATH")]
    [StringLength(1000)]
    public string FilePath { get; set; }
}
