﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_NOTE")]
public partial class ContractNote
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CONTRACT_NOTE_ID")]
    public int ContractNoteId { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    public string ContractCode { get; set; }

    [Column("CONTRACT_VERSION")]
    public int? ContractVersion { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("TITLE")]
    [StringLength(100)]
    public string Title { get; set; }

    [Column("TAGS")]
    [StringLength(50)]
    public string Tags { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
