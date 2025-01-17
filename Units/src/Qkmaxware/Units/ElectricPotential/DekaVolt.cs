namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for DekaVolt (daV)
	/// </summary>
	public struct DekaVolt : IElectricPotential {
        public static string Name => "DekaVolt";
        public static string Symbol => "daV";
    }
	
	/// <summary>
	/// Extension method factory for generating DekaVolt (daV)
	/// </summary>
	public static class DekaVoltFactory {
		/// <summary>
        /// Create a quantity measured in DekaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaVolt> daV<T>(this T value) {
            return new Quantity<T, DekaVolt> (value);
        }
	}
}