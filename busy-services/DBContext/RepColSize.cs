using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class RepColSize
{
    public short RepId { get; set; }

    public short SubId { get; set; }

    public short ColId { get; set; }

    public int ColSize { get; set; }

    public string FormatName { get; set; } = null!;

    public string CustomRepFormatName { get; set; } = null!;

    public bool WideScreen { get; set; }
}
