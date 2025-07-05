using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class RepOptValue
{
    public short RepId { get; set; }

    public short ReportType { get; set; }

    public short ValueType { get; set; }

    public string Value { get; set; } = null!;

    public short MasterType { get; set; }

    public short FieldId { get; set; }

    public string FieldValue { get; set; } = null!;

    public short SubRepId { get; set; }

    public string FormatName { get; set; } = null!;
}
