using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Keyless]
[Table("ITEM_PACK_USER")]
public partial class ItemPackUser
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }

    [Column("ITEM_PACK")]
    public string ItemPack { get; set; }

    [Column("CREATE_BY")]
    [StringLength(50)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    [Precision(6)]
    public DateTime? CreateTime { get; set; }

    [Column("UPDATED_TIME")]
    [Precision(6)]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
