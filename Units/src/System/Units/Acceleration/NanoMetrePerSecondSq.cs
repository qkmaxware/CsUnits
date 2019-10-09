namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the NanoMetrePerSecondSq (nm/s^2)
	/// </summary>
	public struct NanoMetrePerSecondSq : IAcceleration {
        public static string Name => "NanoMetrePerSecondSq";
        public static string Symbol => "nm/s^2";
    }
	
	public static class NanoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in NanoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoMetrePerSecondSq> nm_s2<T>(this T value) {
            return new Quantity<T, NanoMetrePerSecondSq> (value);
        }
	}
}