namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the KiloPascal (kPa)
	/// </summary>
	public struct KiloPascal : IPressure {
        public static string Name => "KiloPascal";
        public static string Symbol => "kPa";
    }
	
	public static class KiloPascalFactory {
		/// <summary>
        /// Create a quantity measured in KiloPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloPascal> kPa<T>(this T value) {
            return new Quantity<T, KiloPascal> (value);
        }
	}
}