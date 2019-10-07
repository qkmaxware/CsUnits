namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the ZeptoJoule (zJ)
	/// </summary>
	public struct ZeptoJoule : IEnergy {
        public static string Name => "ZeptoJoule";
        public static string Symbol => "zJ";
    }
	
	public static class ZeptoJouleFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoJoule> zJ<T>(this T value) {
            return new Quantity<T, ZeptoJoule> (value);
        }
	}
}