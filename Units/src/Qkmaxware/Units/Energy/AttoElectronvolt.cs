namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for AttoElectronvolt (aeV)
	/// </summary>
	public struct AttoElectronvolt : IEnergy {
        public static string Name => "AttoElectronvolt";
        public static string Symbol => "aeV";
    }
	
	/// <summary>
	/// Extension method factory for generating AttoElectronvolt (aeV)
	/// </summary>
	public static class AttoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in AttoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoElectronvolt> aeV<T>(this T value) {
            return new Quantity<T, AttoElectronvolt> (value);
        }
	}
}