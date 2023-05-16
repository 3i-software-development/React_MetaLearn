using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_FILE")]
public partial class ContractFile
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CONTRACT_FILE_ID")]
    public int ContractFileId { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ContractCode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    public string FileCode { get; set; }
}
