using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran10
{
    public short RecType { get; set; }

    public short VchType { get; set; }

    public short I1 { get; set; }

    public short I2 { get; set; }

    public short I3 { get; set; }

    public short I4 { get; set; }

    public short SrNo { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }

    public double D5 { get; set; }

    public double D6 { get; set; }

    public double D7 { get; set; }

    public double D8 { get; set; }

    public double D9 { get; set; }

    public double D10 { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string C3 { get; set; } = null!;

    public string C4 { get; set; } = null!;

    public string C5 { get; set; } = null!;

    public string C6 { get; set; } = null!;

    public string C7 { get; set; } = null!;

    public string C8 { get; set; } = null!;

    public string C9 { get; set; } = null!;

    public string C10 { get; set; } = null!;

    public DateTime Date { get; set; }

    public int MasterCode3 { get; set; }

    public bool B1 { get; set; }

    public bool B2 { get; set; }

    public bool B3 { get; set; }

    public string M1 { get; set; } = null!;
}
