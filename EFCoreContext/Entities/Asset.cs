using System.Collections.Generic;

namespace EFCoreContext.Entities
{
    public class Asset
    {
        public Asset()
        {
            MonitoringLogs = new HashSet<MonitoringLog>();
        }

        public int AssetId { get; set; }

        public virtual ICollection<MonitoringLog> MonitoringLogs { get; set; }

    }
}
