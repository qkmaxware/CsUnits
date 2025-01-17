namespace Qkmaxware.Units.Temperature {

    public struct Celsius : ITemperature {
        public static string Name => "Celsius";
        public static string Symbol => "°C";
    }

    /// <summary>
	///Extension method factory for generating Celsius (°C)
	/// </summary>
	public static class CelsiusFactory {
        /// <summary>
        /// Create a quantity measured in Celsius
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Celsius> degC<T>(this T value) {
            return value.As<Celsius, T>();
        }
    }

}