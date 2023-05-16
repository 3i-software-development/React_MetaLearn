using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_VAYXE_MATERIAL_GOODS")]
public partial class RmVayxeMaterialGood
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE_ID")]
    [StringLength(100)]
    public string CodeId { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(250)]
    public string ProductName { get; set; }

    [Column("GROUP_ID")]
    [StringLength(50)]
    public string GroupId { get; set; }

    [Column("TYPE_ID")]
    [StringLength(50)]
    public string TypeId { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("ACCESSORY")]
    public int? Accessory { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("CREATED_TIME", TypeName = "datetime")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME", TypeName = "datetime")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("BARCODE")]
    [StringLength(20)]
    [Unicode(false)]
    public string Barcode { get; set; }

    [Column("IMAGE")]
    public string Image { get; set; }
}
