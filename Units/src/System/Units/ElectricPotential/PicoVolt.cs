namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the PicoVolt (pV)
	/// </summary>
	public struct PicoVolt : IElectricPotential {
        public static string Name => "PicoVolt";
        public static string Symbol => "pV";
    }
	
	public static class PicoVoltFactory {
		/// <summary>
        /// Create a quantity measured in PicoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoVolt> pV<T>(this T value) {
            return new Quantity<T, PicoVolt> (value);
        }
	}
}