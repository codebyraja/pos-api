using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class ItemParamDet
{
    public DateTime Date { get; set; }

    public short VchType { get; set; }

    public int VchCode { get; set; }

    public string VchNo { get; set; } = null!;

    public short RecType { get; set; }

    public short VchItemSn { get; set; }

    public int ItemCode { get; set; }

    public int Mccode { get; set; }

    public short SrNo { get; set; }

    public short I1 { get; set; }

    public short I2 { get; set; }

    public int Cm1 { get; set; }

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

    public string C11 { get; set; } = null!;

    public string C12 { get; set; } = null!;

    public string C13 { get; set; } = null!;

    public double Value1 { get; set; }

    public double Value2 { get; set; }

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

    public double D11 { get; set; }

    public string Bcn { get; set; } = null!;

    public int AutoBcn { get; set; }

    public DateTime OrgDate { get; set; }

    public int OrgVchCode { get; set; }
}
