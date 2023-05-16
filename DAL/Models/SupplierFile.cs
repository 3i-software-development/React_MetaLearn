using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SUPPLIER_FILE")]
public partial class SupplierFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SUPPLIER_ID")]
    public int? SupplierId { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }
}
