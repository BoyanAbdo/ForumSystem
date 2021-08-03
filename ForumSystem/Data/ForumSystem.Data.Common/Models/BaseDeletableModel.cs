namespace ForumSystem.Data.Common.Models
{
    using System;

    public abstract class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        // Nullable
        public DateTime? DeletedOn { get; set; }
    }
}
