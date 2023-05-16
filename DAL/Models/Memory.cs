using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Memory
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Comment { get; set; }

    public bool? Incense { get; set; }

    public bool? Flower { get; set; }

    public string Ip { get; set; }

    public string Martyrs { get; set; }
}
