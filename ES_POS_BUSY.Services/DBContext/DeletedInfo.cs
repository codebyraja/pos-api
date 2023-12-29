using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class DeletedInfo
{
    public short Type { get; set; }

    public short VchMastType { get; set; }

    public string Identity { get; set; } = null!;

    public string DeletedBy { get; set; } = null!;

    public DateTime DeletionTime { get; set; }

    public double OrgVchAmtBaseCur { get; set; }

    public double ModVchAmtBaseCur { get; set; }

    public string ComputerName { get; set; } = null!;
}
