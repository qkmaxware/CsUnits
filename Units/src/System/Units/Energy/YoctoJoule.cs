namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the YoctoJoule (yJ)
	/// </summary>
	public struct YoctoJoule : IEnergy {
        public static string Name => "YoctoJoule";
        public static string Symbol => "yJ";
    }
	
	public static class YoctoJouleFactory {
		/// <summary>
        /// Create a quantity measured in YoctoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoJoule> yJ<T>(this T value) {
            return new Quantity<T, YoctoJoule> (value);
        }
	}
}