using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Vatinfo
{
    public DateTime Date { get; set; }

    public double Amount { get; set; }

    public short RecType { get; set; }

    public short Type { get; set; }

    public short SrNo { get; set; }

    public string Description { get; set; } = null!;

    public int VchCode { get; set; }

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

    public double SurchargeAmt { get; set; }

    public double SaleAmt { get; set; }

    public double TaxPercent { get; set; }

    public double SurchargePercent { get; set; }

    public bool PaymtToTaxFreePlanet { get; set; }
}
