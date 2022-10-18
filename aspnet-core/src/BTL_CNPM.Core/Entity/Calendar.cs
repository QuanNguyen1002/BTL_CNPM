using Abp.Domain.Entities.Auditing;
using Castle.Facilities.Startable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.Entity
{
    public class Calendar : FullAuditedEntity<long>
    {
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; }
        public long TeamId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public CalendarType CalendarType { get; set; }
    }
    public enum CalendarType: byte
    {
        
    }
}
