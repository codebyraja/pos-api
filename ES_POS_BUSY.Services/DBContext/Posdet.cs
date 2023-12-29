using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Posdet
{
    public int VchCode { get; set; }

    public double CashAmt { get; set; }

    public double ChequeAmt { get; set; }

    public double Ccamt1 { get; set; }

    public double Ccamt2 { get; set; }

    public double Ccamt3 { get; set; }

    public string CashNarr { get; set; } = null!;

    public string ChequeNarr { get; set; } = null!;

    public string Ccnarr1 { get; set; } = null!;

    public string Ccnarr2 { get; set; } = null!;

    public string Ccnarr3 { get; set; } = null!;

    public double CashRecdAmt { get; set; }

    public int CashAccCode { get; set; }

    public int CcaccCode1 { get; set; }

    public int CcaccCode2 { get; set; }

    public int CcaccCode3 { get; set; }

    public int ChequeAccCode { get; set; }
}
