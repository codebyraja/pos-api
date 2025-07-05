using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran4
{
    public int SrNo { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public int BranchCode { get; set; }

    public short RecType { get; set; }
}
