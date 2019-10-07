namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the FemtoMetre (fm)
	/// </summary>
	public struct FemtoMetre : ILength {
        public static string Name => "FemtoMetre";
        public static string Symbol => "fm";
    }
	
	public static class FemtoMetreFactory {
		/// <summary>
        /// Create a quantity measured in FemtoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoMetre> fm<T>(this T value) {
            return new Quantity<T, FemtoMetre> (value);
        }
	}
}