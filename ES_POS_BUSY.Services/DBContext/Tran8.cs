using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran8
{
    public int VchCode { get; set; }

    public short VchType { get; set; }

    public DateTime Date { get; set; }

    public DateTime FormRecDate { get; set; }

    public string FormNo { get; set; } = null!;

    public int PartyCode { get; set; }

    public int FormCode { get; set; }

    public int Stamp { get; set; }

    public string Nar1 { get; set; } = null!;

    public int AutoVchNo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string AuthorisedBy { get; set; } = null!;

    public DateTime AuthorisationTime { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModificationTime { get; set; }

    public short StateCode { get; set; }

    public string Series { get; set; } = null!;

    public string IssuingOffice { get; set; } = null!;
}
