using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("PROJECT_SERVICE_HEADER")]
public partial class ProjectServiceHeader
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("TICKET_COUNT")]
    public int? TicketCount { get; set; }

    [Column("TITLE")]
    [StringLength(500)]
    public string Title { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(255)]
    public string ProjectCode { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("PORT_TYPE")]
    [StringLength(255)]
    public string PortType { get; set; }

    [Column("TICKET_TIME")]
    public DateTime? TicketTime { get; set; }

    [Column("SENDER")]
    [StringLength(255)]
    public string Sender { get; set; }

    [Column("RECEIVER")]
    [StringLength(255)]
    public string Receiver { get; set; }

    [Column("SUPPLIER")]
    [StringLength(255)]
    public string Supplier { get; set; }

    [Column("STATUS_OBJECT_LOG")]
    public string StatusObjectLog { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
