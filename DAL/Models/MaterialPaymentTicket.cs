using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MATERIAL_PAYMENT_TICKET")]
public partial class MaterialPaymentTicket
{
    [Key]
    [Column("PAYMENT_TICKIT_ID")]
    public int PaymentTickitId { get; set; }

    [Column("PAY_CODE")]
    [StringLength(100)]
    public string PayCode { get; set; }

    [Column("PAY_TITLE")]
    [StringLength(255)]
    public string PayTitle { get; set; }

    [Column("PAY_NOTE")]
    [StringLength(255)]
    public string PayNote { get; set; }

    [Column("PAY_TYPE")]
    public bool? PayType { get; set; }

    [Column("PAY_OBJ_TYPE")]
    [StringLength(50)]
    public string PayObjType { get; set; }

    [Column("PAY_OBJ_ID")]
    [StringLength(100)]
    public string PayObjId { get; set; }

    [Column("MONEY_TOTAL", TypeName = "decimal(18, 0)")]
    public decimal? MoneyTotal { get; set; }

    [Column("CURRENCY")]
    [StringLength(20)]
    public string Currency { get; set; }

    [Column("PAY_OF_WAY")]
    [StringLength(50)]
    public string PayOfWay { get; set; }

    [Column("PAYER_ID")]
    [StringLength(100)]
    public string PayerId { get; set; }

    [Column("RECEIPER_ID")]
    [StringLength(100)]
    public string ReceiperId { get; set; }

    [Column("PAY_TIME_CNT")]
    public DateTime? PayTimeCnt { get; set; }

    [Column("PAY_REMAIN")]
    [StringLength(100)]
    public string PayRemain { get; set; }

    [Column("PAY_NEXT_TIME")]
    public DateTime? PayNextTime { get; set; }

    [Column("PAY_NEXT_MONEY", TypeName = "decimal(18, 0)")]
    public decimal? PayNextMoney { get; set; }

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
}
