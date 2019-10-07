namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the TeraCandela (Tcd)
	/// </summary>
	public struct TeraCandela : ILuminosity {
        public static string Name => "TeraCandela";
        public static string Symbol => "Tcd";
    }
	
	public static class TeraCandelaFactory {
		/// <summary>
        /// Create a quantity measured in TeraCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraCandela> Tcd<T>(this T value) {
            return new Quantity<T, TeraCandela> (value);
        }
	}
}