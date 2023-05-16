using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Cemetery
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public string Icon { get; set; }

    public string Note { get; set; }

    public string GisData { get; set; }

    public int? NumberMartyrs { get; set; }

    public string PositionGps { get; set; }

    public string Address { get; set; }
}
