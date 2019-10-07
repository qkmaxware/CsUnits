namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the MilliAmpere (mA)
	/// </summary>
	public struct MilliAmpere : ICurrent {
        public static string Name => "MilliAmpere";
        public static string Symbol => "mA";
    }
	
	public static class MilliAmpereFactory {
		/// <summary>
        /// Create a quantity measured in MilliAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliAmpere> mA<T>(this T value) {
            return new Quantity<T, MilliAmpere> (value);
        }
	}
}