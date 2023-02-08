namespace OmerBlog.Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid? Id { get; set; } = Guid.NewGuid();

        public virtual string CreatedBy { get; set; }

        public virtual string? ModifiedBy { get; set; }

        public virtual string? DeletedBy { get; set; }

        public virtual DateTime? CreatedOn { get; set; } = DateTime.Now;

        public virtual DateTime? ModifiedOn { get; set; }

        public virtual DateTime? DeletedOn { get; set; }

        public virtual bool IsDeleted { get; set; } = false;
    }
}
