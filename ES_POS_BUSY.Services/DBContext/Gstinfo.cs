using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Gstinfo
{
    public DateTime Date { get; set; }

    public double Amount { get; set; }

    public short RecType { get; set; }

    public short Type { get; set; }

    public short SrNo { get; set; }

    public string Description { get; set; } = null!;

    public int VchCode { get; set; }

    public short I1 { get; set; }

    public string ChallanNo { get; set; } = null!;

    public DateTime ChallanDate { get; set; }

    public string ChequeNo { get; set; } = null!;

    public DateTime ChequeDate { get; set; }

    public string BankName { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public double Interest { get; set; }

    public double Penalty { get; set; }

    public string BankAcType { get; set; } = null!;

    public string BankAcNo { get; set; } = null!;

    public double Cgstpercent { get; set; }

    public double Sgstpercent { get; set; }

    public double Igstpercent { get; set; }

    public double CessPercent { get; set; }

    public double AcessPercent { get; set; }

    public double Cgstamt { get; set; }

    public double Sgstamt { get; set; }

    public double Igstamt { get; set; }

    public double CessAmt { get; set; }

    public double AcessAmt { get; set; }

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

    public double LateFee { get; set; }
}
