namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the PicoMetrePerSecond (pm/s)
	/// </summary>
	public struct PicoMetrePerSecond : IVelocity {
        public static string Name => "PicoMetrePerSecond";
        public static string Symbol => "pm/s";
    }
	
	public static class PicoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in PicoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoMetrePerSecond> pm_s<T>(this T value) {
            return new Quantity<T, PicoMetrePerSecond> (value);
        }
	}
}