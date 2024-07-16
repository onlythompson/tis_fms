

namespace tis_fms_domain.seed_work
{
    /// <summary>
    /// Represents the base domain model from which other domain models inherit.
    /// Provides common properties and methods that are shared across derived domain models.
    /// </summary>
    public class BaseDomain
    {
        /// <summary>
        /// Represents the base domain model from which other domain models inherit.
        /// Provides common properties and methods that are shared across derived domain models.
        /// </summary>
        private Guid _Id;
        /// <summary>
        /// Represents the base domain model from which other domain models inherit.
        /// Provides common properties and methods that are shared across derived domain models.
        /// </summary>
        int? _requestedHashCode;

        /// <summary>
        /// Gets the unique identifier for the domain object.
        /// </summary>
        /// <returns>The unique identifier as a <see cref="Guid"/>.</returns>
        public virtual Guid Id => _Id;

        /// <summary>
        /// Indicates whether the domain object is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; protected set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDomain"/> class.
        /// </summary>
        public BaseDomain()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDomain"/> class with a specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the domain object.</param>
        public BaseDomain(Guid id)
        {
            this._Id = id;
        }

        /// <summary>
        /// Generates a new identity for the domain object if it is transient (i.e., does not have an identity yet).
        /// </summary>
        public void GenerateNewIdentity()
        {
            if (Istransient())
                this._Id = Guid.NewGuid();
        }

        /// <summary>
        /// Determines whether the domain object is transient, i.e., does not have a persistent identity.
        /// </summary>
        /// <returns>true if the domain object is transient; otherwise, false.</returns>
        public bool Istransient()
        {
            return this.Id == Guid.Empty;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is BaseDomain))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, obj))
                return true;

            BaseDomain item = (BaseDomain)obj;

            if (item.Istransient() || this.Istransient())
                return false;
            else
                return item.Id == this.Id;
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="BaseDomain"/> are equal.
        /// </summary>
        /// <param name="base1">The first object to compare.</param>
        /// <param name="base2">The second object to compare.</param>
        /// <returns>true if base1 and base2 represent the same object; otherwise, false.</returns>
        public static bool operator ==(BaseDomain base1, BaseDomain base2)
        {
            if (base1 is null && base2 is null)
            {
                return true;
            }

            if (base1 is null || base2 is null)
            {
                return false;
            }

            return base1.Id == base2.Id;
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="BaseDomain"/> are not equal.
        /// </summary>
        /// <param name="base1">The first object to compare.</param>
        /// <param name="base2">The second object to compare.</param>
        /// <returns>true if base1 and base2 do not represent the same object; otherwise, false.</returns>
        public static bool operator !=(BaseDomain base1, BaseDomain base2)
        {
            return !(base1 == base2);
        }

        /// <summary>
        /// Calculates or retrieves a cached hash code for the domain object. If the hash code has not been requested before,
        /// it calculates a new hash code by XORing the hash code of the <see cref="Id"/> property with the prime number 31.
        /// This calculated hash code is cached for future use. If the hash code has already been calculated, it returns the cached value.
        /// </summary>
        /// <returns>The hash code as an <see cref="int"/>.</returns>
        public override int GetHashCode()
        {
            if (!Istransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31;

                return _requestedHashCode.Value;
            }
            return this._Id.GetHashCode();
        }

        /// <summary>
        /// Marks the domain object as deleted by setting the <see cref="IsDeleted"/> property to true.
        /// </summary>
        public virtual void Destroy()
        {

            IsDeleted = true;

        }
    }
}