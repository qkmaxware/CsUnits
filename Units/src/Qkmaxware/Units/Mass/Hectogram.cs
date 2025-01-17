namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for HectoGram (hg)
	/// </summary>
	public struct HectoGram : IMass {
        public static string Name => "HectoGram";
        public static string Symbol => "hg";
    }
	
	/// <summary>
	/// Extension method factory for generating HectoGram (hg)
	/// </summary>
	public static class HectoGramFactory {
		/// <summary>
        /// Create a quantity measured in HectoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoGram> hg<T>(this T value) {
            return new Quantity<T, HectoGram> (value);
        }
	}
}