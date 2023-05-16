using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_VAYXE_BOOK_MATERIAL_DETAILS")]
public partial class RmVayxeBookMaterialDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOOK_CHK_ID")]
    public int? BookChkId { get; set; }

    [Column("MATERIAL_ID")]
    public int? MaterialId { get; set; }

    [Column("AMOUNT")]
    public int? Amount { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("PRICE")]
    public double? Price { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
