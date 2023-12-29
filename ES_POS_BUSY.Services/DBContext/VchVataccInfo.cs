using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class VchVataccInfo
{
    public int VchCode { get; set; }

    public int ItemCode { get; set; }

    public short ItemSrNo { get; set; }

    public int PartyCode { get; set; }

    public int TaxCatCode { get; set; }

    public int Stptcode { get; set; }

    public string VchNo { get; set; } = null!;

    public int VchSeriesCode { get; set; }

    public DateTime VchDate { get; set; }

    public short VchType { get; set; }

    public string Hsncode { get; set; } = null!;

    public string Seno { get; set; } = null!;

    public string PartyStateTinDigit { get; set; } = null!;

    public int PartyStateCode { get; set; }

    public string BdstateTinDigit { get; set; } = null!;

    public int BdstateCode { get; set; }

    public double TaxableAmt { get; set; }

    public double TaxRate { get; set; }

    public double TaxRate1 { get; set; }

    public double TaxAmt { get; set; }

    public double TaxAmt1 { get; set; }

    public double SurchargeRate { get; set; }

    public double SurchargeAmt { get; set; }

    public double AcessRate { get; set; }

    public double AcessAmt { get; set; }

    public short LocType { get; set; }

    public short ZeroTaxType { get; set; }

    public double ActualSaleAmt { get; set; }

    public bool TaxOnMrp { get; set; }

    public double ItemMainQty { get; set; }

    public double ItemAltQty { get; set; }

    public short I1 { get; set; }

    public short I2 { get; set; }

    public short I3 { get; set; }

    public string OrgVchNo { get; set; } = null!;

    public DateTime OrgVchDate { get; set; }

    public short RecType { get; set; }

    public short GstrepBasis { get; set; }

    public short TypeOfDealer { get; set; }

    public string PosstateTinDigit { get; set; } = null!;

    public int PosstateCode { get; set; }

    public double D1 { get; set; }

    public int Cm1 { get; set; }
}
