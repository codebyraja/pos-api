using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class VchTempTagging
{
    public int MasterCode { get; set; }

    public short VchType { get; set; }

    public int TemplateVchCode { get; set; }

    public bool B1 { get; set; }

    public bool B2 { get; set; }

    public bool B3 { get; set; }

    public bool B4 { get; set; }

    public bool B5 { get; set; }

    public short I1 { get; set; }

    public short I2 { get; set; }

    public short MasterType { get; set; }
}
