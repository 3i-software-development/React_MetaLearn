using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_AUDIO_BOOK")]
public partial class EdmsAudioBook
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_ID")]
    public int? FileId { get; set; }

    [Column("INDEX")]
    public int? Index { get; set; }

    [Column("AUDIO_PATH")]
    [StringLength(1000)]
    public string AudioPath { get; set; }
}
