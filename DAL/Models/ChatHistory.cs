using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CHAT_HISTORY")]
public partial class ChatHistory
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("MESSAGE")]
    [StringLength(100)]
    public string Message { get; set; }

    [Column("MESSAGE_TYPE")]
    [StringLength(100)]
    public string MessageType { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(100)]
    public string GroupCode { get; set; }

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
