namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the FemtoElectronvolt (feV)
	/// </summary>
	public struct FemtoElectronvolt : IEnergy {
        public static string Name => "FemtoElectronvolt";
        public static string Symbol => "feV";
    }
	
	public static class FemtoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in FemtoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoElectronvolt> feV<T>(this T value) {
            return new Quantity<T, FemtoElectronvolt> (value);
        }
	}
}