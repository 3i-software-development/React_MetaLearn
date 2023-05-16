using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_WAREHOUSE_MEDIA")]
public partial class EdmsWarehouseMedium
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WHS_CODE")]
    [StringLength(100)]
    public string WhsCode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    public string FileCode { get; set; }
}
