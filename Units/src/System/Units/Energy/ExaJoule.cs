namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the ExaJoule (EJ)
	/// </summary>
	public struct ExaJoule : IEnergy {
        public static string Name => "ExaJoule";
        public static string Symbol => "EJ";
    }
	
	public static class ExaJouleFactory {
		/// <summary>
        /// Create a quantity measured in ExaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaJoule> EJ<T>(this T value) {
            return new Quantity<T, ExaJoule> (value);
        }
	}
}