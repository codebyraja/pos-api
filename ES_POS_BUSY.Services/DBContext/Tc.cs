using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tc
{
    public short Method { get; set; }

    public string RefNo { get; set; } = null!;

    public int RefCode { get; set; }

    public short SrNo { get; set; }

    public int VchCode { get; set; }

    public short VchType { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public DateTime EntryDate { get; set; }

    public DateTime DateOfCredit { get; set; }

    public double VchAmt { get; set; }

    public double Tcsrate { get; set; }

    public double Tcsamt { get; set; }

    public double SurchargeRate { get; set; }

    public double SurchargeAmt { get; set; }

    public double Interest { get; set; }

    public double OtherAmt { get; set; }

    public bool LowerRate { get; set; }

    public string Reason { get; set; } = null!;

    public string ChallanNo { get; set; } = null!;

    public string ChequeNo { get; set; } = null!;

    public DateTime ChequeDate { get; set; }

    public short Quarter { get; set; }

    public short RecType { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string SubCategoryCode { get; set; } = null!;

    public string Bsrcode { get; set; } = null!;
}
