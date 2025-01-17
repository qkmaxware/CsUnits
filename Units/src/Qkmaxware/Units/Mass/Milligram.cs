namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for MilliGram (mg)
	/// </summary>
	public struct MilliGram : IMass {
        public static string Name => "MilliGram";
        public static string Symbol => "mg";
    }
	
	/// <summary>
	/// Extension method factory for generating MilliGram (mg)
	/// </summary>
	public static class MilliGramFactory {
		/// <summary>
        /// Create a quantity measured in MilliGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliGram> mg<T>(this T value) {
            return new Quantity<T, MilliGram> (value);
        }
	}
}