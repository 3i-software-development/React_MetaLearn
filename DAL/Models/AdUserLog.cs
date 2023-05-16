using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AdUserLog
{
    public int Id { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Log Type: 1. Login, 2. Create, 3. Update, 4. Delete
    /// </summary>
    public short? LogType { get; set; }

    public string UserIp { get; set; }

    public string Content { get; set; }

    public int? UserId { get; set; }

    public string FullName { get; set; }
}
