using Abp.Domain.Entities.Auditing;
using BTL_CNPM.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.Entity
{
    public class Member : FullAuditedEntity<long>
    {
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; }
        public long TeamId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public long UserId { get; set; }
        [ForeignKey(nameof(TeamRoleId))]
        public TeamRole TeamRole { get; set; }
        public long TeamRoleId { get; set; }
    }
}
