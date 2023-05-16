using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("USER_ACCESS_DATA_KEYWORD")]
public partial class UserAccessDataKeyword
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER")]
    [StringLength(255)]
    public string User { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    public string Group { get; set; }

    [Column("KEY_WORD_LIST")]
    public string KeyWordList { get; set; }
}
