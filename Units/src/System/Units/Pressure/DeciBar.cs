namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the DeciBar (dbar)
	/// </summary>
	public struct DeciBar : IPressure {
        public static string Name => "DeciBar";
        public static string Symbol => "dbar";
    }
	
	public static class DeciBarFactory {
		/// <summary>
        /// Create a quantity measured in DeciBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciBar> dbar<T>(this T value) {
            return new Quantity<T, DeciBar> (value);
        }
	}
}