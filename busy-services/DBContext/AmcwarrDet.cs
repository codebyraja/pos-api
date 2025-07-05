using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class AmcwarrDet
{
    public int VchCode { get; set; }

    public int SrNo { get; set; }

    public short Rectype { get; set; }

    public DateTime Date { get; set; }

    public string VchNo { get; set; } = null!;

    public string RefNo { get; set; } = null!;

    public string ItemSerialNo { get; set; } = null!;

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public double Value1 { get; set; }

    public int Cm1 { get; set; }

    public string Narration { get; set; } = null!;

    public DateTime ContEndDate { get; set; }

    public short I1 { get; set; }

    public short Status { get; set; }
}
