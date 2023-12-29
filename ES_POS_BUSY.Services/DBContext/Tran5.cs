using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran5
{
    public int VchCode { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public short SrNo { get; set; }

    public short VchType { get; set; }

    public DateTime Date { get; set; }

    public string VchNo { get; set; } = null!;

    public int VchSeriesCode { get; set; }

    public double Value1 { get; set; }

    public double Value2 { get; set; }

    public double Balance1 { get; set; }

    public double Balance2 { get; set; }

    public short TranType { get; set; }

    public string ShortNar { get; set; } = null!;

    public string TrackingNo { get; set; } = null!;

    public short TrackingStatus { get; set; }
}
