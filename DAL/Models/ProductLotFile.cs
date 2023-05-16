using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PRODUCT_LOT_FILE")]
public partial class ProductLotFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(500)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(500)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }
}
