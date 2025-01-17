namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for YottaPascal (YPa)
	/// </summary>
	public struct YottaPascal : IPressure {
        public static string Name => "YottaPascal";
        public static string Symbol => "YPa";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaPascal (YPa)
	/// </summary>
	public static class YottaPascalFactory {
		/// <summary>
        /// Create a quantity measured in YottaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaPascal> YPa<T>(this T value) {
            return new Quantity<T, YottaPascal> (value);
        }
	}
}