using System;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseUser
    {
        public string UserId { get; set; }

        public string UserLevel { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public int Locked { get; set; }

        public string LocationLdap { get; set; }

        public DateTime TrainingComplete { get; set; }

        public DateTime LastLogin { get; set; }

        public bool Deleted { get; set; }

        public DateTime DeletedDate { get; set; }

        public string DeletedBy { get; set; }
    }
}
