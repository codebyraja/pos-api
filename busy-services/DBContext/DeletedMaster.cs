using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class DeletedMaster
{
    public short MasterType { get; set; }

    public string Name { get; set; } = null!;
}
