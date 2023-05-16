using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROD_DELIVERY_ATTR_VALUE")]
public partial class ProdDeliveryAttrValue
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_EXP_CODE")]
    [StringLength(255)]
    public string TicketExpCode { get; set; }

    [Column("PROD_CODE")]
    [StringLength(255)]
    public string ProdCode { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    public string Code { get; set; }

    [Column("VALUE")]
    [StringLength(255)]
    public string Value { get; set; }

    [Column("MARK_TYPE")]
    [StringLength(255)]
    public string MarkType { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }
}
