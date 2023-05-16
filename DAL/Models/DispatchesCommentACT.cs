using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_COMMENT_ACT")]
public partial class DispatchesCommentAct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROCESS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProcessCode { get; set; }

    [Column("COMMENT")]
    public string Comment { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
