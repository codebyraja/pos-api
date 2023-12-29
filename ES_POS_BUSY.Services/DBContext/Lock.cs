using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Lock
{
    public DateTime Type { get; set; }

    public bool Ibr { get; set; }

    public bool Mbu { get; set; }

    public bool Csu { get; set; }

    public bool Stu { get; set; }

    public bool Working { get; set; }

    public bool Bsstd { get; set; }

    public bool Terbr { get; set; }

    public bool Brs { get; set; }

    public bool Cccf { get; set; }

    public bool SuppTypeF { get; set; }

    public bool Bsnf { get; set; }

    public bool Bst { get; set; }

    public bool Ospo { get; set; }

    public bool Obamc { get; set; }

    public bool Tdsshe { get; set; }

    public bool Tesrno { get; set; }

    public short Major { get; set; }

    public short Minor { get; set; }

    public bool Rw35 { get; set; }

    public bool Mebr { get; set; }

    public bool Mebr1 { get; set; }

    public bool Mffsa { get; set; }

    public bool Smpl { get; set; }

    public bool Gstu { get; set; }

    public bool Muspo { get; set; }

    public bool Dfyw { get; set; }

    public bool Batch { get; set; }

    public bool Batchmrpsrnoparam { get; set; }

    public bool Entrytaxrate { get; set; }

    public bool Stptmc { get; set; }

    public bool Challanno { get; set; }

    public bool Paramdet { get; set; }

    public bool Mastfp { get; set; }

    public bool Mastfp1 { get; set; }

    public bool Rmvlocdb { get; set; }

    public bool Posseriesftbsname { get; set; }

    public bool Stscgupdt { get; set; }

    public bool ItemSrNoLen { get; set; }

    public bool Rgmast { get; set; }

    public short MainDbVer { get; set; }

    public short PartialDbVer { get; set; }

    public bool Compegrpmast { get; set; }

    public bool Compcontgrpmast { get; set; }

    public bool Areamast { get; set; }

    public bool Contdeptmast { get; set; }

    public bool Sourcemast { get; set; }

    public bool Substatusmast { get; set; }

    public bool Nxtactionmast { get; set; }

    public bool Trademast { get; set; }

    public bool B1 { get; set; }

    public bool Faqgrpmast { get; set; }

    public bool Pendsubstatusmast { get; set; }

    public bool Trackingno { get; set; }

    public string WinUser { get; set; } = null!;

    public string Piipd { get; set; } = null!;

    public bool Tofq { get; set; }

    public string CompanyName { get; set; } = null!;

    public bool UrefBal { get; set; }
}
