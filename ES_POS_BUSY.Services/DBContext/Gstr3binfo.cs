using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Gstr3binfo
{
    public short RecType { get; set; }

    public short TranType { get; set; }

    public short Month { get; set; }

    public string Year { get; set; } = null!;

    public string Gstin { get; set; } = null!;

    public string Type { get; set; } = null!;

    public double TaxableAmt { get; set; }

    public double Tax { get; set; }

    public double Cgst { get; set; }

    public double Sgst { get; set; }

    public double Igst { get; set; }

    public double CessAmt { get; set; }

    public double Fee { get; set; }

    public double Inter { get; set; }

    public double Intera { get; set; }

    public short I1 { get; set; }

    public short I2 { get; set; }

    public string Pos { get; set; } = null!;

    public bool B1 { get; set; }

    public bool B2 { get; set; }

    public bool B3 { get; set; }

    public bool B4 { get; set; }

    public bool B5 { get; set; }

    public int LdgId { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public int Cm3 { get; set; }

    public int Cm4 { get; set; }

    public int Cm5 { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public DateTime Date1 { get; set; }

    public string M1 { get; set; } = null!;
}
