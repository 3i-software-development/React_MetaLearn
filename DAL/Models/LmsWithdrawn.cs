using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_WITHDRAWN")]
public partial class LmsWithdrawn
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("WITHDRAW_CODE")]
    [StringLength(255)]
    public string WithdrawCode { get; set; }

    [Column("AMOUNT", TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }

    [Column("NOTED")]
    [StringLength(255)]
    public string Noted { get; set; }

    [Column("USER_REQUEST")]
    [StringLength(50)]
    public string UserRequest { get; set; }

    [Column("REQUEST_TIME")]
    [Precision(6)]
    public DateTime? RequestTime { get; set; }

    [Column("FROM_IP")]
    [StringLength(50)]
    public string FromIp { get; set; }

    [Column("FROM_DEVICE")]
    [StringLength(50)]
    public string FromDevice { get; set; }

    [Column("PAYMENT_TYPE")]
    [StringLength(255)]
    public string PaymentType { get; set; }

    [Column("TRANSACTION_LOG")]
    public string TransactionLog { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("USER_PAY")]
    [StringLength(50)]
    public string UserPay { get; set; }

    [Column("CREATE_BY")]
    [StringLength(50)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    [Precision(6)]
    public DateTime? CreateTime { get; set; }

    [Column("UPDATED_TIME")]
    [Precision(6)]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
