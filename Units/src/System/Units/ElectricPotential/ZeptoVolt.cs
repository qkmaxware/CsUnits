namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the ZeptoVolt (zV)
	/// </summary>
	public struct ZeptoVolt : IElectricPotential {
        public static string Name => "ZeptoVolt";
        public static string Symbol => "zV";
    }
	
	public static class ZeptoVoltFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoVolt> zV<T>(this T value) {
            return new Quantity<T, ZeptoVolt> (value);
        }
	}
}