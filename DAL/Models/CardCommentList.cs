using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CARD_COMMENT_LIST")]
public partial class CardCommentList
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(255)]
    public string BoardCode { get; set; }

    [Column("CMT_ID")]
    [StringLength(255)]
    public string CmtId { get; set; }

    [Column("CMT_CONTENT")]
    public string CmtContent { get; set; }

    [Column("MEMBER_ID")]
    [StringLength(255)]
    public string MemberId { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("FLAG")]
    public bool Flag { get; set; }

    [Column("REF_PARENT")]
    public int? RefParent { get; set; }

    [Column("LIKE")]
    public int? Like { get; set; }

    [Column("DISLIKE")]
    public int? Dislike { get; set; }

    [Column("LIKE_LOG")]
    public string LikeLog { get; set; }

    [Column("JSON_CANVAS")]
    public string JsonCanvas { get; set; }

    [Column("IS_GPT_ANSWERED")]
    public bool? IsGptAnswered { get; set; }

    [Column("GPT_ANSWER")]
    public string GptAnswer { get; set; }
}
