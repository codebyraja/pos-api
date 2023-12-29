using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class CheckList
{
    public short Type { get; set; }

    public int Code { get; set; }

    public short Action { get; set; }

    public DateTime ActionTime { get; set; }

    public string UserName { get; set; } = null!;

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }

    public double D5 { get; set; }

    public string Notes { get; set; } = null!;

    public string ComputerName { get; set; } = null!;
}
