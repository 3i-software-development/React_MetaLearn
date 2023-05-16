using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_LOADING_SMS_BANK")]
public partial class FundLoadingSmsBank
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACC_SENDER")]
    [StringLength(255)]
    [Unicode(false)]
    public string AccSender { get; set; }

    [Column("SENDER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Sender { get; set; }

    [Column("ACC_RECEIVER")]
    [StringLength(255)]
    [Unicode(false)]
    public string AccReceiver { get; set; }

    [Column("RECEIVER")]
    public string Receiver { get; set; }

    [Column("MONEY_TRANFER")]
    [StringLength(255)]
    [Unicode(false)]
    public string MoneyTranfer { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    [Unicode(false)]
    public string Currency { get; set; }

    [Column("TRANFER_TIME", TypeName = "datetime")]
    public DateTime? TranferTime { get; set; }

    [Column("ACC_BALANCE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AccBalance { get; set; }

    [Column("SMS_RAW")]
    [StringLength(500)]
    [Unicode(false)]
    public string SmsRaw { get; set; }

    [Column("SMS_STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string SmsStatus { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_DATE")]
    public DateTime? DeletedDate { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("CURRENCY_BALANCE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CurrencyBalance { get; set; }

    [Column("BANK_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string BankName { get; set; }
}
