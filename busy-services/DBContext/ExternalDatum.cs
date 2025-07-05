using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class ExternalDatum
{
    public short KeyType { get; set; }

    public int KeyCode { get; set; }

    public string AppName { get; set; } = null!;

    public bool CanEditKeyData { get; set; }

    public bool CanDeleteKeyData { get; set; }

    public short I1 { get; set; }

    public int L1 { get; set; }

    public double D1 { get; set; }

    public bool B1 { get; set; }

    public DateTime Dt1 { get; set; }

    public string C1 { get; set; } = null!;

    public bool Connected { get; set; }

    public int ConnectedCode { get; set; }
}
