

namespace tis_fms_domain.shared_kernel
{
    /// <summary>
    /// Represents a monetary value with an associated currency.
    /// This class provides an immutable representation of money, ensuring that the amount and currency properties cannot be changed after an instance is created.
    /// </summary>
    public class Money
    {
        /// <summary>
        /// Gets the amount of money.
        /// </summary>
        /// <value>The monetary value as a decimal.</value>
        public decimal Amount { get; } // Immutable properties

        /// <summary>
        /// Gets the currency of the money.
        /// </summary>
        /// <value>The currency as a string.</value>
        public string Currency { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class with a specified amount and currency.
        /// </summary>
        /// <param name="amount">The amount of money.</param>
        /// <param name="currency">The currency of the money.</param>
        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Money"/> instance is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Money"/> instance to compare with the current instance.</param>
        /// <returns>true if the specified <see cref="Money"/> is equal to the current instance; otherwise, false.</returns>
        public bool Equals(Money other) => Amount == other.Amount && Currency == other.Currency;

        /// <summary>
        /// Determines whether the specified object is equal to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>true if the specified object is a <see cref="Money"/> and equal to the current instance; otherwise, false.</returns>
        public override bool Equals(object? obj) => obj is Money other && Equals(other);

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current instance.</returns>
        public override int GetHashCode() => HashCode.Combine(Amount, Currency);
    }
}