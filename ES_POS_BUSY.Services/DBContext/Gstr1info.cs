using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Gstr1info
{
    public short RecType { get; set; }

    public short TranType { get; set; }

    public short Month { get; set; }

    public string Year { get; set; } = null!;

    public short SrNo { get; set; }

    public string Gstin { get; set; } = null!;

    public string CompGstin { get; set; } = null!;

    public DateTime Date { get; set; }

    public string VchNo { get; set; } = null!;

    public DateTime CrDate { get; set; }

    public string CrNo { get; set; } = null!;

    public string InvType { get; set; } = null!;

    public string Updby { get; set; } = null!;

    public string CheckSum { get; set; } = null!;

    public double TotalAmt { get; set; }

    public double TaxableAmt { get; set; }

    public double Rate { get; set; }

    public double Cgst { get; set; }

    public double Sgst { get; set; }

    public double Igst { get; set; }

    public double CessAmt { get; set; }

    public string Pos { get; set; } = null!;

    public bool Cfs { get; set; }

    public string CName { get; set; } = null!;

    public string Flag { get; set; } = null!;

    public bool Rchrg { get; set; }

    public bool CFlag { get; set; }

    public string Uqc { get; set; } = null!;

    public double Qty { get; set; }

    public string Hsnsc { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public bool PGst { get; set; }

    public string SupplyType { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Cancel { get; set; }

    public int Num { get; set; }

    public int Totnum { get; set; }

    public string Docfrom { get; set; } = null!;

    public string DocTo { get; set; } = null!;

    public int Netissue { get; set; }

    public int Docnum { get; set; }

    public DateTime FilDate { get; set; }

    public string FilType { get; set; } = null!;

    public short I1 { get; set; }

    public short I2 { get; set; }

    public bool B1 { get; set; }

    public bool B2 { get; set; }

    public bool B3 { get; set; }

    public bool B4 { get; set; }

    public bool B5 { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public int Cm3 { get; set; }

    public int Cm4 { get; set; }

    public int Cm5 { get; set; }

    public DateTime Date1 { get; set; }

    public DateTime Date2 { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string M1 { get; set; } = null!;
}
