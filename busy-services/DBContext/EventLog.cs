using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class EventLog
{
    public string UserName { get; set; } = null!;

    public DateTime Date { get; set; }

    public short WorkedOn { get; set; }

    public string Description { get; set; } = null!;

    public int Uid { get; set; }

    public string ComputerName { get; set; } = null!;

    public string VersionNo { get; set; } = null!;

    public string S1 { get; set; } = null!;

    public int SessionId { get; set; }
}
