using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DepRecord : Base
    {
        public Guid? MainRecordId { get; set; }
        public MainRecord MainRecord { get; set; }
        public virtual IList<DepRecord> DepRecords { get; set; } = new List<DepRecord>();
    }
}
