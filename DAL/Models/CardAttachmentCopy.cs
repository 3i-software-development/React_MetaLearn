using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CARD_ATTACHMENT_copy")]
public partial class CardAttachmentCopy
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(255)]
    public string FileCode { get; set; }

    [Column("MEMBER_ID")]
    [StringLength(255)]
    public string MemberId { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_URL")]
    [StringLength(255)]
    public string FileUrl { get; set; }

    /// <summary>
    /// Type=0(Tệp tin), Type=1(Hình ảnh)
    /// </summary>
    [Column("FILE_TYPE")]
    public int? FileType { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("IS_EDIT")]
    public bool? IsEdit { get; set; }

    [Column("LIST_USER_VIEW")]
    public string ListUserView { get; set; }

    [Column("LIST_PERMISSION_VIEW_FILE")]
    [Unicode(false)]
    public string ListPermissionViewFile { get; set; }

    [Column("CHK_LIST_CODE")]
    [StringLength(255)]
    public string ChkListCode { get; set; }

    [Column("IS_EDMS")]
    public bool? IsEdms { get; set; }

    [Column("ID_MAPPING")]
    public int? IdMapping { get; set; }
}
