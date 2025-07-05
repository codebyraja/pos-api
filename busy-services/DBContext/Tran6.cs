using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran6
{
    public int SrNo { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public short StockType { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }
}
