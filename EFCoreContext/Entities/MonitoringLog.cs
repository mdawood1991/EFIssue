using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreContext.Entities
{
    public class MonitoringLog
    {
        public int MonitoringLogId { get; set; }

        public DateTime LogUTCDateTime {get;set;}

        public string OtherProperty { get; set; }

        public int AssetId { get; set; }
        public virtual Asset Asset { get; set; }

    }
}
