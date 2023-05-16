using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_HEADER")]
public partial class DispatchesHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DOCUMENT_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentCode { get; set; }

    [Column("DOCUMENT_NUMBER")]
    public int DocumentNumber { get; set; }

    [Column("DOCUMENT_SYMBOL")]
    [StringLength(255)]
    public string DocumentSymbol { get; set; }

    [Column("ORIGANIZATION")]
    [StringLength(255)]
    public string Origanization { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("PROMULGATE_DATE")]
    public DateTime? PromulgateDate { get; set; }

    [Column("EPITOME")]
    [StringLength(1000)]
    public string Epitome { get; set; }

    [Column("DOCUMENT_ZONE")]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentZone { get; set; }

    [Column("DOCUMENT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentType { get; set; }

    [Column("SIGN_USER")]
    [StringLength(100)]
    public string SignUser { get; set; }

    [Column("POSITION")]
    [StringLength(255)]
    public string Position { get; set; }

    [Column("CONFIDENTIALITY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Confidentiality { get; set; }

    [Column("GET_MOTHOD")]
    [StringLength(50)]
    public string GetMothod { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_EDITOR")]
    [StringLength(50)]
    public string CreatedEditor { get; set; }

    [Column("UNIT_EDITOR")]
    [StringLength(255)]
    public string UnitEditor { get; set; }

    [Column("IS_REPLY")]
    public bool? IsReply { get; set; }

    [Column("IS_PROCESS")]
    public bool? IsProcess { get; set; }

    [Column("REPLY_STATUS")]
    [StringLength(255)]
    public string ReplyStatus { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("EXPERIED_REPLY")]
    public DateTime? ExperiedReply { get; set; }

    [Column("DISPATCH_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string DispatchCode { get; set; }

    [Column("IMPORTANT_LEVEL")]
    [StringLength(50)]
    [Unicode(false)]
    public string ImportantLevel { get; set; }

    [Column("SECURITY_LEVEL")]
    [StringLength(50)]
    [Unicode(false)]
    public string SecurityLevel { get; set; }

    [Column("IS_QPPL")]
    public bool? IsQppl { get; set; }

    [Column("TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("DOCUMENT_SYMBOLS")]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentSymbols { get; set; }

    [Column("USER_EDITOR")]
    [StringLength(100)]
    [Unicode(false)]
    public string UserEditor { get; set; }

    [Column("SIGN_DATE")]
    public DateTime? SignDate { get; set; }

    [Column("CREATED_USER_ID")]
    [StringLength(50)]
    public string CreatedUserId { get; set; }

    [Column("YEAR")]
    public int? Year { get; set; }
}
