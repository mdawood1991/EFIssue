using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6Context.Entities
{
    [Table("Asset")]
    public class Asset
    {
        public Asset()
        {
            MonitoringLogs = new HashSet<MonitoringLog>();
        }

        [Key]
        public int AssetId { get; set; }

        public virtual ICollection<MonitoringLog> MonitoringLogs { get; set; }

    }
}
