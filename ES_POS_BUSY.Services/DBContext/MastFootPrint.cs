using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class MastFootPrint
{
    public int MasterCode { get; set; }

    public string Name { get; set; } = null!;

    public short MasterType { get; set; }

    public int Stamp { get; set; }

    public string PartialFp { get; set; } = null!;

    public string RemainFp { get; set; } = null!;
}
