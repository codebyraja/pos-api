using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class TradingExcise
{
    public int RefCode { get; set; }

    public int Stamp { get; set; }

    public short Method { get; set; }

    public int VchCode { get; set; }

    public short SrNo { get; set; }

    public short VchType { get; set; }

    public string RefNo { get; set; } = null!;

    public int PartyCode { get; set; }

    public string VchNo { get; set; } = null!;

    public DateTime Date { get; set; }

    public int ItemCode { get; set; }

    public double Qty { get; set; }

    public double Balance { get; set; }

    public short Status { get; set; }

    public double AssValue { get; set; }

    public double DutyRate { get; set; }

    public short DutyType { get; set; }

    public double DutyAmt { get; set; }

    public double DutyRate1 { get; set; }

    public short DutyType1 { get; set; }

    public double DutyAmt1 { get; set; }

    public double DutyRate2 { get; set; }

    public short DutyType2 { get; set; }

    public double DutyAmt2 { get; set; }

    public double DutyRate3 { get; set; }

    public short DutyType3 { get; set; }

    public double DutyAmt3 { get; set; }

    public double MfrQty { get; set; }

    public int MfrCode { get; set; }

    public string MfrBillNo { get; set; } = null!;

    public DateTime MfrBillDate { get; set; }

    public string Rg23dpageNo { get; set; } = null!;

    public string Rg23dsrNo { get; set; } = null!;

    public int AutoRg23dpageNo { get; set; }

    public int AutoRg23dsrNo { get; set; }

    public string SuppRg23dpageNo { get; set; } = null!;

    public string SuppRg23dsrNo { get; set; } = null!;

    public int Mccode { get; set; }

    public double SuppAssValue { get; set; }

    public double SuppDutyAmt { get; set; }

    public double SuppDutyAmt1 { get; set; }

    public double SuppDutyAmt2 { get; set; }

    public double SuppDutyAmt3 { get; set; }

    public bool CarryRefZeroQty { get; set; }

    public string MfrInvoicePrepDateTime { get; set; } = null!;

    public string MfrGoodsRemovalDateTime { get; set; } = null!;

    public double ActualSuppAssValue { get; set; }

    public double ActualSuppDutyAmt { get; set; }

    public double ActualSuppDutyAmt1 { get; set; }

    public double ActualSuppDutyAmt2 { get; set; }

    public double ActualSuppDutyAmt3 { get; set; }

    public double ActualSuppQty { get; set; }

    public bool SuppOrgDetailsSpecified { get; set; }
}
