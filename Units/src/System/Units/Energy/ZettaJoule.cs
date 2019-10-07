namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the ZettaJoule (ZJ)
	/// </summary>
	public struct ZettaJoule : IEnergy {
        public static string Name => "ZettaJoule";
        public static string Symbol => "ZJ";
    }
	
	public static class ZettaJouleFactory {
		/// <summary>
        /// Create a quantity measured in ZettaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaJoule> ZJ<T>(this T value) {
            return new Quantity<T, ZettaJoule> (value);
        }
	}
}