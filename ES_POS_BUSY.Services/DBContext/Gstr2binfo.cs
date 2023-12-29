using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Gstr2binfo
{
    public short RecType { get; set; }

    public short TranType { get; set; }

    public short Month { get; set; }

    public string Year { get; set; } = null!;

    public int SrNo { get; set; }

    public string Gstin { get; set; } = null!;

    public string CompGstin { get; set; } = null!;

    public string TradeName { get; set; } = null!;

    public DateTime SupplierFilDate { get; set; }

    public string SupplierPrd { get; set; } = null!;

    public DateTime Date { get; set; }

    public string VchNo { get; set; } = null!;

    public DateTime OrgDate { get; set; }

    public string OrgVchNo { get; set; } = null!;

    public string InvType { get; set; } = null!;

    public string Updby { get; set; } = null!;

    public string CheckSum { get; set; } = null!;

    public string Type { get; set; } = null!;

    public double TotalAmt { get; set; }

    public double TaxableAmt { get; set; }

    public double Rate { get; set; }

    public double Cgst { get; set; }

    public double Sgst { get; set; }

    public double Igst { get; set; }

    public double CessAmt { get; set; }

    public double Itccgst { get; set; }

    public double Itcsgst { get; set; }

    public double Itcigst { get; set; }

    public double ItccessAmt { get; set; }

    public string Itcelg { get; set; } = null!;

    public double DiffPercent { get; set; }

    public bool Itcavl { get; set; }

    public string Reason { get; set; } = null!;

    public short I1 { get; set; }

    public short I2 { get; set; }

    public short Pos { get; set; }

    public bool B1 { get; set; }

    public bool B2 { get; set; }

    public bool B3 { get; set; }

    public bool B4 { get; set; }

    public bool B5 { get; set; }

    public bool Cfs { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public int Cm3 { get; set; }

    public int Cm4 { get; set; }

    public int Cm5 { get; set; }

    public DateTime Date1 { get; set; }

    public DateTime Date2 { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string NoteNo { get; set; } = null!;

    public DateTime NoteDate { get; set; }

    public string M1 { get; set; } = null!;
}
