namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for YottaNewton (YN)
	/// </summary>
	public struct YottaNewton : IForce {
        public static string Name => "YottaNewton";
        public static string Symbol => "YN";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaNewton (YN)
	/// </summary>
	public static class YottaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in YottaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaNewton> YN<T>(this T value) {
            return new Quantity<T, YottaNewton> (value);
        }
	}
}