namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the Metre (m)
	/// </summary>
	public struct Metre : ILength {
        public static string Name => "Metre";
        public static string Symbol => "m";
    }
	
	public static class MetreFactory {
		/// <summary>
        /// Create a quantity measured in Metres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Metre> m<T>(this T value) {
            return new Quantity<T, Metre> (value);
        }
	}
}