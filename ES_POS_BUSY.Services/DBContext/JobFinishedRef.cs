using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class JobFinishedRef
{
    public string JobId { get; set; } = null!;

    public short TranType { get; set; }

    public int VchCode { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public short SrNo { get; set; }

    public short VchType { get; set; }

    public DateTime Date { get; set; }

    public string VchNo { get; set; } = null!;

    public int VchSeriesCode { get; set; }

    public int Cm1 { get; set; }

    public double Value1 { get; set; }

    public double Value2 { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string C3 { get; set; } = null!;

    public DateTime Date1 { get; set; }

    public short Rectype { get; set; }
}
