using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class ItemSerialNo
{
    public int VchCode { get; set; }

    public short VchType { get; set; }

    public string VchNo { get; set; } = null!;

    public short VchItemSn { get; set; }

    public DateTime Date { get; set; }

    public int ItemCode { get; set; }

    public int Mccode { get; set; }

    public int GridSn { get; set; }

    public string SerialNo { get; set; } = null!;

    public int AutoSrNo { get; set; }

    public double Value1 { get; set; }

    public double Value2 { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }

    public short MonthVal { get; set; }

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

    public short WarrantyMonth { get; set; }
}
