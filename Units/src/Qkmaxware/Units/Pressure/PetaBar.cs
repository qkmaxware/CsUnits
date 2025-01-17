namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for PetaBar (Pbar)
	/// </summary>
	public struct PetaBar : IPressure {
        public static string Name => "PetaBar";
        public static string Symbol => "Pbar";
    }
	
	/// <summary>
	/// Extension method factory for generating PetaBar (Pbar)
	/// </summary>
	public static class PetaBarFactory {
		/// <summary>
        /// Create a quantity measured in PetaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaBar> Pbar<T>(this T value) {
            return new Quantity<T, PetaBar> (value);
        }
	}
}