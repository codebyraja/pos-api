using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class CloudSyncIncrDet
{
    public int Code { get; set; }

    public short SrNo { get; set; }

    public string Xmlstr { get; set; } = null!;
}
