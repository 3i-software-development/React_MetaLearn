using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_CATEGORY")]
public partial class EdmsCategory
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CAT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CatCode { get; set; }

    [Column("CAT_NAME")]
    [StringLength(255)]
    public string CatName { get; set; }

    [Column("CAT_PARENT")]
    [StringLength(100)]
    [Unicode(false)]
    public string CatParent { get; set; }

    [Column("MODULE_FILE_UPLOAD_DEFAULT")]
    [StringLength(255)]
    public string ModuleFileUploadDefault { get; set; }

    [Column("PATH_SERVER_PHYSIC")]
    [StringLength(255)]
    public string PathServerPhysic { get; set; }

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
