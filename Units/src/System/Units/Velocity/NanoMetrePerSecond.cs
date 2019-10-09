namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the NanoMetrePerSecond (nm/s)
	/// </summary>
	public struct NanoMetrePerSecond : IVelocity {
        public static string Name => "NanoMetrePerSecond";
        public static string Symbol => "nm/s";
    }
	
	public static class NanoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in NanoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoMetrePerSecond> nm_s<T>(this T value) {
            return new Quantity<T, NanoMetrePerSecond> (value);
        }
	}
}