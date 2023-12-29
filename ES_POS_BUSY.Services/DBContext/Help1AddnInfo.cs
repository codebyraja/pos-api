using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Help1AddnInfo
{
    public int Code { get; set; }

    public string NameAlias { get; set; } = null!;

    public short NameOrAlias { get; set; }

    public string AddnInfoBt1 { get; set; } = null!;

    public string AddnInfoBt2 { get; set; } = null!;

    public string AddnInfoBt3 { get; set; } = null!;

    public string AddnInfoBt4 { get; set; } = null!;
}
