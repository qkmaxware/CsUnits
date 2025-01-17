namespace Qkmaxware.Units.Current {
	/// <summary>
	/// Unit of measurement for ExaAmpere (EA)
	/// </summary>
	public struct ExaAmpere : ICurrent {
        public static string Name => "ExaAmpere";
        public static string Symbol => "EA";
    }
	
	/// <summary>
	/// Extension method factory for generating ExaAmpere (EA)
	/// </summary>
	public static class ExaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in ExaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaAmpere> EA<T>(this T value) {
            return new Quantity<T, ExaAmpere> (value);
        }
	}
}