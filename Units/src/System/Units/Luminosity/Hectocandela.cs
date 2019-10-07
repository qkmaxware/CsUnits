namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the HectoCandela (hcd)
	/// </summary>
	public struct HectoCandela : ILuminosity {
        public static string Name => "HectoCandela";
        public static string Symbol => "hcd";
    }
	
	public static class HectoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in HectoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoCandela> hcd<T>(this T value) {
            return new Quantity<T, HectoCandela> (value);
        }
	}
}