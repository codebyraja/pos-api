using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class VchTemplate
{
    public int VchCode { get; set; }

    public string TemplateName { get; set; } = null!;
}
