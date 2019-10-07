namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the TeraJoule (TJ)
	/// </summary>
	public struct TeraJoule : IEnergy {
        public static string Name => "TeraJoule";
        public static string Symbol => "TJ";
    }
	
	public static class TeraJouleFactory {
		/// <summary>
        /// Create a quantity measured in TeraJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraJoule> TJ<T>(this T value) {
            return new Quantity<T, TeraJoule> (value);
        }
	}
}