using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran11
{
    public short RecType { get; set; }

    public short TranType { get; set; }

    public int VchCode { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public short SrNo { get; set; }

    public short VchType { get; set; }

    public DateTime Date { get; set; }

    public string VchNo { get; set; } = null!;

    public int VchSeriesCode { get; set; }

    public string ShortNar { get; set; } = null!;

    public short I1 { get; set; }

    public short I2 { get; set; }

    public bool B1 { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public int Cm3 { get; set; }

    public int Cm4 { get; set; }

    public int Cm5 { get; set; }

    public int Cm6 { get; set; }

    public int Cm7 { get; set; }

    public int Cm8 { get; set; }

    public DateTime Date1 { get; set; }

    public DateTime Date2 { get; set; }

    public DateTime Date3 { get; set; }

    public DateTime Date4 { get; set; }

    public DateTime Date5 { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string M1 { get; set; } = null!;

    public string M2 { get; set; } = null!;
}
