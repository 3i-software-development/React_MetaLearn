using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_RECEIPT_INPUT_STORE")]
public partial class EdmsReceiptInputStore
{
    [Key]
    public int Id { get; set; }

    [Column("RC_TICKET_CODE")]
    [StringLength(255)]
    public string RcTicketCode { get; set; }

    [Column("BR_CODE")]
    [StringLength(255)]
    public string BrCode { get; set; }

    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("WHS_USER")]
    [StringLength(255)]
    public string WhsUser { get; set; }

    [Column("NUM_BOX")]
    [StringLength(255)]
    public string NumBox { get; set; }

    [Column("DOC_TYPE")]
    [StringLength(255)]
    public string DocType { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("RC_SUPPORT")]
    [StringLength(255)]
    public string RcSupport { get; set; }

    [Column("RC_STATUS")]
    [StringLength(255)]
    public string RcStatus { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    public string QrCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("RQ_ID")]
    public int? RqId { get; set; }

    [Column("PERSON_SENDER")]
    [StringLength(255)]
    public string PersonSender { get; set; }
}
