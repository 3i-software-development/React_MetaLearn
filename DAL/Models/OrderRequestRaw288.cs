using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ORDER_REQUEST_RAW_28_8")]
public partial class OrderRequestRaw288
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("REQ_CODE")]
    [StringLength(100)]
    public string ReqCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("CONTENT")]
    public string Content { get; set; }

    [Column("IP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Ip { get; set; }

    [Column("DEVICE")]
    [StringLength(255)]
    public string Device { get; set; }

    [Column("PRIORITY")]
    public int? Priority { get; set; }

    [Column("REQUEST_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string RequestType { get; set; }

    [Column("REQUEST_TIME")]
    public DateTime? RequestTime { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("KEYWORD")]
    [StringLength(255)]
    public string Keyword { get; set; }

    [Column("PHONE")]
    [StringLength(50)]
    public string Phone { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    public string Email { get; set; }

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
