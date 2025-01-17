namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for GigaJoule (GJ)
	/// </summary>
	public struct GigaJoule : IEnergy {
        public static string Name => "GigaJoule";
        public static string Symbol => "GJ";
    }
	
	/// <summary>
	/// Extension method factory for generating GigaJoule (GJ)
	/// </summary>
	public static class GigaJouleFactory {
		/// <summary>
        /// Create a quantity measured in GigaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaJoule> GJ<T>(this T value) {
            return new Quantity<T, GigaJoule> (value);
        }
	}
}