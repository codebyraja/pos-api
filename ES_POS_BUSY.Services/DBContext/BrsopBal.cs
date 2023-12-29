using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class BrsopBal
{
    public short SrNo { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public double OpAmt { get; set; }

    public short Type { get; set; }

    public string ShortNar { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public DateTime ClrDate { get; set; }

    public int OldVchCode { get; set; }

    public string VchNo { get; set; } = null!;

    public short I1 { get; set; }

    public string C1 { get; set; } = null!;
}
