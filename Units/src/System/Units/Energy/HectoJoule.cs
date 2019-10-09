namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the HectoJoule (hJ)
	/// </summary>
	public struct HectoJoule : IEnergy {
        public static string Name => "HectoJoule";
        public static string Symbol => "hJ";
    }
	
	public static class HectoJouleFactory {
		/// <summary>
        /// Create a quantity measured in HectoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoJoule> hJ<T>(this T value) {
            return new Quantity<T, HectoJoule> (value);
        }
	}
}