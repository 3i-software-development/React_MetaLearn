using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("NOTIFICATION")]
public partial class Notification
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("NOTIFY_ID")]
    public int NotifyId { get; set; }

    [Column("NOTIFY_CODE")]
    [StringLength(100)]
    public string NotifyCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("CONTENT")]
    public string Content { get; set; }

    [Column("DATE_EVENT")]
    public DateTime? DateEvent { get; set; }

    [Column("DATE_WARNING")]
    public DateTime? DateWarning { get; set; }

    [Column("IS_WARNING")]
    public bool? IsWarning { get; set; }

    [Column("LST_CONTRACT_CODE")]
    [StringLength(100)]
    public string LstContractCode { get; set; }

    [Column("RECEIVER")]
    [StringLength(255)]
    public string Receiver { get; set; }

    [Column("RECEIVER_CONFIRM")]
    [StringLength(50)]
    public string ReceiverConfirm { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("CREATE_BY")]
    [StringLength(50)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

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
