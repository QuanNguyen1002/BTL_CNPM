using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.Entity
{
    public class Event : FullAuditedEntity<long>
    {
        public string Name { get; set; }
        public DateTime BeginHour { get; set; }
        public DateTime EndHour { get; set; }
        public bool HasNotification { get; set; }
        public long TimeBeforNotification{ get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string AddressAt { get; set; }
        public EventType EventType { get; set; }
        [ForeignKey(nameof(CalendarId))]
        public Calendar Calendar { get; set; }
        public long CalendarId { get; set; }
    }
    public enum EventType: byte
    {

    }
}
