using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class CloudSyncStatus
{
    public short BulkStatus { get; set; }

    public string BulkStatusDet { get; set; } = null!;

    public DateTime BulkDateTime { get; set; }

    public string BulkComputerName { get; set; } = null!;

    public string BulkIp { get; set; } = null!;

    public short IncrStatus { get; set; }

    public string IncrStatusDet { get; set; } = null!;

    public DateTime IncrDateTime { get; set; }

    public string IncrComputerName { get; set; } = null!;

    public string IncrIp { get; set; } = null!;
}
