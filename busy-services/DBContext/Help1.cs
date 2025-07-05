using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Help1
{
    public short RecType { get; set; }

    public string NameAlias { get; set; } = null!;

    public int Code { get; set; }

    public short MasterType { get; set; }

    public short NameOrAlias { get; set; }

    public string AdditionalInfo { get; set; } = null!;

    public int ParentGroup { get; set; }

    public int MasterSeries { get; set; }

    public short Status { get; set; }

    public int DefaultMccode { get; set; }

    public string AddnInfoBt1 { get; set; } = null!;

    public string AddnInfoBt2 { get; set; } = null!;

    public string AddnInfoBt3 { get; set; } = null!;

    public string AddnInfoBt4 { get; set; } = null!;
}
