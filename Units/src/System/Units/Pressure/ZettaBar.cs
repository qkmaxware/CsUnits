namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the ZettaBar (Zbar)
	/// </summary>
	public struct ZettaBar : IPressure {
        public static string Name => "ZettaBar";
        public static string Symbol => "Zbar";
    }
	
	public static class ZettaBarFactory {
		/// <summary>
        /// Create a quantity measured in ZettaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaBar> Zbar<T>(this T value) {
            return new Quantity<T, ZettaBar> (value);
        }
	}
}