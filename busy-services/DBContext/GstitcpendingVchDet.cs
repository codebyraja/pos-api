using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class GstitcpendingVchDet
{
    public int VchCode { get; set; }

    public int VchSeriesCode { get; set; }

    public int ItemCode { get; set; }

    public short ItemSrNo { get; set; }

    public int TaxCatCode { get; set; }

    public int Stptcode { get; set; }

    public short VchType { get; set; }

    public short RecType { get; set; }

    public short LocType { get; set; }

    public DateTime Date1 { get; set; }

    public DateTime VchDate { get; set; }

    public string VchNo { get; set; } = null!;

    public string PartyName { get; set; } = null!;

    public string Gstin { get; set; } = null!;

    public string Hsncode { get; set; } = null!;

    public string Seno { get; set; } = null!;

    public string PartyStateTinDigit { get; set; } = null!;

    public int PartyStateCode { get; set; }

    public string BdstateTinDigit { get; set; } = null!;

    public int BdstateCode { get; set; }

    public double ActualSaleAmt { get; set; }

    public double TaxableAmt { get; set; }

    public double TaxRate { get; set; }

    public double TaxRate1 { get; set; }

    public double TaxAmt { get; set; }

    public double TaxAmt1 { get; set; }

    public double CessRate { get; set; }

    public double CessAmt { get; set; }

    public double AddCessRate { get; set; }

    public double AddCessAmt { get; set; }

    public double StateCessRate { get; set; }

    public double StateCessAmt { get; set; }

    public short ZeroTaxType { get; set; }

    public bool TaxOnMrp { get; set; }

    public double ItemMainQty { get; set; }

    public double ItemAltQty { get; set; }

    public short I1 { get; set; }

    public short I2 { get; set; }

    public short I3 { get; set; }

    public short GstrepBasis { get; set; }

    public short TypeOfDealer { get; set; }

    public string PosstateTinDigit { get; set; } = null!;

    public int PosstateCode { get; set; }

    public double D1 { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public short ItcclaimedStatus { get; set; }

    public short ItcclaimedMonth { get; set; }

    public string OrgVchNo { get; set; } = null!;

    public DateTime OrgVchDate { get; set; }

    public short Gstr2bstatus { get; set; }

    public short Gstr2bmonth { get; set; }

    public short Gstr2byear { get; set; }
}
