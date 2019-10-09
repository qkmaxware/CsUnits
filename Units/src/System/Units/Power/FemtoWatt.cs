namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the FemtoWatt (fW)
	/// </summary>
	public struct FemtoWatt : IPower {
        public static string Name => "FemtoWatt";
        public static string Symbol => "fW";
    }
	
	public static class FemtoWattFactory {
		/// <summary>
        /// Create a quantity measured in FemtoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoWatt> fW<T>(this T value) {
            return new Quantity<T, FemtoWatt> (value);
        }
	}
}