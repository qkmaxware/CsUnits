namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for ZettaPascal (ZPa)
	/// </summary>
	public struct ZettaPascal : IPressure {
        public static string Name => "ZettaPascal";
        public static string Symbol => "ZPa";
    }
	
	/// <summary>
	/// Extension method factory for generating ZettaPascal (ZPa)
	/// </summary>
	public static class ZettaPascalFactory {
		/// <summary>
        /// Create a quantity measured in ZettaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaPascal> ZPa<T>(this T value) {
            return new Quantity<T, ZettaPascal> (value);
        }
	}
}