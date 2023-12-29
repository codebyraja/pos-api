using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class CloudSyncIncr
{
    public int Code { get; set; }

    public short Type { get; set; }

    public short SubType { get; set; }

    public short Action { get; set; }

    public int VchMastCode { get; set; }

    public DateTime EntryDateTime { get; set; }

    public string Error { get; set; } = null!;

    public short Status { get; set; }

    public string SelfImageLink { get; set; } = null!;

    public string BusyDocLink { get; set; } = null!;

    public short FormatType { get; set; }
}
