using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class GetCountCardWork
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("SUM_CARD_WORK")]
    public int? SumCardWork { get; set; }

    [Column("CARD_WORK_PENDING")]
    public int? CardWorkPending { get; set; }

    [Column("CARD_WORK_SUCCESS")]
    public int? CardWorkSuccess { get; set; }

    [Column("CARD_WORKCANCEL")]
    public int? CardWorkcancel { get; set; }

    [Column("CARD_WORK_EXPIRES")]
    public int? CardWorkExpires { get; set; }
}
