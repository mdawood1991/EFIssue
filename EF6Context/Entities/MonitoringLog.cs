using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6Context.Entities
{
    [Table("MonitoringLog")]
    public class MonitoringLog
    {
        [Key]
        public int MonitoringLogId { get; set; }

        public DateTime LogUTCDateTime { get; set; }

        public string OtherProperty { get; set; }

        [ForeignKey(nameof(Asset))]
        public int AssetId { get; set; }
        public virtual Asset Asset { get; set; }

    }
}
