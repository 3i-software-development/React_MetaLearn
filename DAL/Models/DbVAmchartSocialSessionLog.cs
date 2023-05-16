using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class DbVAmchartSocialSessionLog
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("LST_DAY")]
    public int? LstDay { get; set; }

    [Column("BOT_SESSION_RESULT")]
    public string BotSessionResult { get; set; }
}
