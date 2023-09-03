namespace OnionCrafter.Base.Entities.General
{
    /// <summary>
    /// Represents an entity with a unique identifier of type <typeparamref name="TKey"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of the unique identifier.</typeparam>
    /// <seealso cref="IBaseEntity" />
    public interface IEntity<TKey> : IBaseEntity
        where TKey : notnull, IEquatable<TKey>, IComparable<TKey>
    {
        /// <summary>
        /// Gets the unique identifier of the entity.
        /// </summary>
        public TKey Id { get; protected set; }

        public abstract void SetId(TKey key);
    }

    /// <summary>
    /// Interface for entities that use a string as the key type.
    /// </summary>
    public interface IEntity : IEntity<string>
    {
    }
}