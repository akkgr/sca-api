using System;

namespace Sca.Api.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
    }
}