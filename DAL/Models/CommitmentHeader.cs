using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("COMMITMENT_HEADER")]
public partial class CommitmentHeader
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("COMMITMENT_CODE")]
    [StringLength(225)]
    public string CommitmentCode { get; set; }

    [Column("TITLE")]
    [StringLength(225)]
    public string Title { get; set; }

    [Column("USER_ID")]
    [StringLength(225)]
    public string UserId { get; set; }

    [Column("SURROGATE")]
    [StringLength(225)]
    public string Surrogate { get; set; }

    [Column("STATUS")]
    [StringLength(225)]
    public string Status { get; set; }

    [Column("NOTED")]
    [StringLength(225)]
    public string Noted { get; set; }

    [Column("START_TIME", TypeName = "date")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME", TypeName = "date")]
    public DateTime? EndTime { get; set; }

    [Column("SIGNATURE")]
    [StringLength(3000)]
    public string Signature { get; set; }

    [Column("FILE_REFERENCE")]
    public string FileReference { get; set; }

    [Column("CREATE_TIME", TypeName = "date")]
    public DateTime? CreateTime { get; set; }

    [Column("CREATE_BY")]
    [StringLength(225)]
    public string CreateBy { get; set; }

    [Column("UPDATE_TIME", TypeName = "date")]
    public DateTime? UpdateTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(225)]
    public string UpdateBy { get; set; }

    [Column("USER_SIGN")]
    [StringLength(225)]
    public string UserSign { get; set; }

    [Column("LIST_RULE")]
    [StringLength(225)]
    public string ListRule { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }
}
