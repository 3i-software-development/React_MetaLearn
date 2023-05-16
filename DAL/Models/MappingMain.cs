using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MAPPING_MAIN")]
public partial class MappingMain
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Danh sách tất cả key (Code Y/C đặt hàng, Code Dự án...)
    /// </summary>
    [Column("OBJ_ROOT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjRootCode { get; set; }

    /// <summary>
    /// PROJECT, PO_BUY, PO_SALE, ORDER, REQ_PRICE
    /// </summary>
    [Column("OBJ_TYPE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjType { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    /// <summary>
    /// (Chính, Hỗ trợ, Bổ sung, Phụ lục)
    /// </summary>
    [Column("OBJ_RELATIVE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjRelative { get; set; }

    [Column("OBJ_NOTE")]
    [StringLength(255)]
    public string ObjNote { get; set; }

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

    [Column("OBJ_ROOT_TYPE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjRootType { get; set; }
}
