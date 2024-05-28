using Repositories.Common.Interfaces;

namespace Repositories.Common
{
    public abstract class BaseEntity : IAuditableEntity
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
