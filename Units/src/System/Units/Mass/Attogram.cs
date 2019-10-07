namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the AttoGram (ag)
	/// </summary>
	public struct AttoGram : IMass {
        public static string Name => "AttoGram";
        public static string Symbol => "ag";
    }
	
	public static class AttoGramFactory {
		/// <summary>
        /// Create a quantity measured in AttoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoGram> ag<T>(this T value) {
            return new Quantity<T, AttoGram> (value);
        }
	}
}