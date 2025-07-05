using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class QueryLog
{
    public string UserName { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Qry { get; set; } = null!;

    public short RecType { get; set; }

    public string ErrStr { get; set; } = null!;
}
