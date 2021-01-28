#nullable enable
using System.Globalization;

namespace Netxtendable {

    /// <summary>Class with configuration for methods and classes in this library</summary>
    public static class NetxtendableConfig {

        /// <summary>
        /// Default <see cref="CultureInfo"/> to be used when no culture is specified. By default
        /// <see cref="CultureInfo.InvariantCulture"/> is used.
        /// </summary>
        public static CultureInfo DefaultCulture { get; set; } = CultureInfo.InvariantCulture;
    }
}
