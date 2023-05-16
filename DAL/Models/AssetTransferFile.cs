using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_TRANSFER_FILE")]
public partial class AssetTransferFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKETCODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Ticketcode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }
}
