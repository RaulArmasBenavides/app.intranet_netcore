using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.intranet_netcore.Models.Log
{
    [Table("log", Schema = "admin")]
    public class DbLog
    {
        public int Id { get; set; }
        public string TableName { get; set; } = string.Empty;
        public string ColumnName { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public int? RecordId { get; set; }
        public string? UserName { get; set; }
        public string? IPAddress { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
