
namespace tis_fms_domain.shared_kernel
{
   /// <summary>
    /// Represents a currency with its associated properties such as code, name, symbol, and decimal places.
    /// This class provides an immutable representation of a currency, ensuring that its properties cannot be changed after an instance is created.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Gets the ISO currency code.
        /// </summary>
        /// <value>The currency code as a string.</value>
        public string Code { get; }

        /// <summary>
        /// Gets the full name of the currency.
        /// </summary>
        /// <value>The currency name as a string.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the symbol associated with the currency.
        /// </summary>
        /// <value>The currency symbol as a string.</value>
        public string Symbol { get; }

        /// <summary>
        /// Gets the number of decimal places typically used by the currency.
        /// </summary>
        /// <value>The number of decimal places as a string.</value>
        public short DecimalPlaces { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class with specified details.
        /// </summary>
        /// <param name="id">The unique identifier for the currency.</param>
        /// <param name="code">The ISO currency code.</param>
        /// <param name="name">The full name of the currency.</param>
        /// <param name="symbol">The symbol associated with the currency.</param>
        /// <param name="decimalPlaces">The number of decimal places typically used by the currency.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="id"/> is an empty GUID.</exception>
        public Currency(string code, string name, string symbol, short decimalPlaces = 2)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentException("Currency code cannot be null or empty.", nameof(code));
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Currency name cannot be null or empty.", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(symbol))
            {
                throw new ArgumentException("Currency symbol cannot be null or empty.", nameof(symbol));
            }
            Code = code;
            Name = name;
            Symbol = symbol;
            DecimalPlaces = decimalPlaces;
        }
    }
}