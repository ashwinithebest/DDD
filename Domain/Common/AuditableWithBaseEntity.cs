

namespace Domain.Common
{
    public class AuditableWithBaseEntity<T> : BaseEntity<T>, IAuditableEntity
    {
       public  bool IsDeleted { get; set; }
       public DateTime Created { get; set; }
       public  long Author { get; set; }
       public DateTime? Modified { get; set; }
       public long Editor { get; set; }
        DateTime IAuditableEntity.Modified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
