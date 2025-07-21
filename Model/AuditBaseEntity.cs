namespace CommerceCraft.Api.Model
{
    // Base entity for audit tracking
    public abstract class AuditBaseEntity
    {
        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        // Made nullable so you only set it when a modification happens
        public int? ModifiedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
