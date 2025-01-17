namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for DeciWatt (dW)
	/// </summary>
	public struct DeciWatt : IPower {
        public static string Name => "DeciWatt";
        public static string Symbol => "dW";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciWatt (dW)
	/// </summary>
	public static class DeciWattFactory {
		/// <summary>
        /// Create a quantity measured in DeciWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciWatt> dW<T>(this T value) {
            return new Quantity<T, DeciWatt> (value);
        }
	}
}