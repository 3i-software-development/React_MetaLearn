using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ENTITY_MAPPING")]
public partial class EntityMapping
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PO_SALE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string PoSaleCode { get; set; }

    [Column("PO_BUYER_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string PoBuyerCode { get; set; }

    [Column("REQ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ReqCode { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProjectCode { get; set; }
}
