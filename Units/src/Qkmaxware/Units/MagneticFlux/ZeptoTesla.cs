namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for ZeptoTesla (zT)
	/// </summary>
	public struct ZeptoTesla : IMagneticFlux {
        public static string Name => "ZeptoTesla";
        public static string Symbol => "zT";
    }
	
	/// <summary>
	/// Extension method factory for generating ZeptoTesla (zT)
	/// </summary>
	public static class ZeptoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoTesla> zT<T>(this T value) {
            return new Quantity<T, ZeptoTesla> (value);
        }
	}
}