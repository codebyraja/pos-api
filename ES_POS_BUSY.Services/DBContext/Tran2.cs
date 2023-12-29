using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran2
{
    public short RecType { get; set; }

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

    public double Value3 { get; set; }

    public double Balance1 { get; set; }

    public double Balance2 { get; set; }

    public double Balance3 { get; set; }

    public double ItemBal1 { get; set; }

    public double ItemBal2 { get; set; }

    public double ItemBal3 { get; set; }

    public double CashFlow { get; set; }

    public string ShortNar { get; set; } = null!;

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

    public double D12 { get; set; }

    public double D13 { get; set; }

    public double D14 { get; set; }

    public double D15 { get; set; }

    public double D16 { get; set; }

    public double D17 { get; set; }

    public double D18 { get; set; }

    public double D19 { get; set; }

    public double D20 { get; set; }

    public double D21 { get; set; }

    public double D22 { get; set; }

    public double D23 { get; set; }

    public double D24 { get; set; }

    public double D25 { get; set; }

    public double D26 { get; set; }

    public double D27 { get; set; }

    public double D28 { get; set; }

    public double D29 { get; set; }

    public double D30 { get; set; }

    public double D31 { get; set; }

    public double D32 { get; set; }

    public double D33 { get; set; }

    public double D34 { get; set; }

    public double D35 { get; set; }

    public double D36 { get; set; }

    public double D37 { get; set; }

    public double D38 { get; set; }

    public double D39 { get; set; }

    public short I1 { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public int Cm3 { get; set; }

    public int Cm4 { get; set; }

    public int Cm5 { get; set; }

    public int Cm6 { get; set; }

    public int Cm7 { get; set; }

    public int Cm8 { get; set; }

    public int Cm9 { get; set; }

    public int Cm10 { get; set; }

    public int Cm11 { get; set; }

    public int Cm12 { get; set; }

    public bool B1 { get; set; }

    public bool B2 { get; set; }

    public bool B3 { get; set; }

    public bool B4 { get; set; }

    public bool B5 { get; set; }

    public bool B6 { get; set; }

    public bool B7 { get; set; }

    public bool B8 { get; set; }

    public DateTime ClrDate { get; set; }

    public short PriceCategory { get; set; }

    public short Cfmode { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string C3 { get; set; } = null!;

    public string C4 { get; set; } = null!;

    public short TranType { get; set; }

    public bool IsReturnQty { get; set; }

    public bool ReconStatus { get; set; }

    public short I2 { get; set; }

    public short I3 { get; set; }

    public short I4 { get; set; }

    public short I5 { get; set; }

    public short I6 { get; set; }

    public short I7 { get; set; }

    public short I8 { get; set; }

    public short I9 { get; set; }

    public short I10 { get; set; }

    public short TrackingStatus { get; set; }

    public string TrackingNo { get; set; } = null!;

    public short ConsignmentType { get; set; }

    public bool ConsignmentCleared { get; set; }
}
