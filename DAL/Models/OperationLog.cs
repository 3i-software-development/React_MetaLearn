using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OPERATION_LOG")]
public partial class OperationLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CONTROLLER")]
    [StringLength(255)]
    public string Controller { get; set; }

    [Column("ACTION")]
    [StringLength(255)]
    public string Action { get; set; }

    [Column("PATH")]
    [StringLength(255)]
    public string Path { get; set; }

    [Column("REQUEST_HEADER")]
    public string RequestHeader { get; set; }

    [Column("REQUEST_BODY")]
    public string RequestBody { get; set; }

    [Column("TABLE")]
    [StringLength(255)]
    public string Table { get; set; }

    [Column("IP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Ip { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
