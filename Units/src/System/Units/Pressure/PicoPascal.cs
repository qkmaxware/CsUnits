namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the PicoPascal (pPa)
	/// </summary>
	public struct PicoPascal : IPressure {
        public static string Name => "PicoPascal";
        public static string Symbol => "pPa";
    }
	
	public static class PicoPascalFactory {
		/// <summary>
        /// Create a quantity measured in PicoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoPascal> pPa<T>(this T value) {
            return new Quantity<T, PicoPascal> (value);
        }
	}
}