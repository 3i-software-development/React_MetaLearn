using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_ALLOCATE_FILE")]
public partial class AssetAllocateFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }
}
