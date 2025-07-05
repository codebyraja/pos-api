using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Oeddet
{
    public int VchCode { get; set; }

    public double Oedrate { get; set; }

    public double Oedamount { get; set; }

    public double CessRate { get; set; }

    public double CessAmount { get; set; }

    public double HecessRate { get; set; }

    public double HecessAmount { get; set; }

    public double D1 { get; set; }

    public short I1 { get; set; }

    public int L1 { get; set; }
}
