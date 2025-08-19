using System;

namespace nilnul._time.date_
{
	/// <summary>
	/// ignore the time, and the time is set to all nils;
	/// </summary>
	static public class _ByDatetimeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// as a method, since it's dynamic (the returned value would change every time, so there must be some hidden input parameter.)
		/// </remarks>
		/// <returns></returns>
		static public DateTime Today() {
			var now=DateTime.Now;
			return new DateTime(
				now.Year
				,
				now.Month
				,
				now.Day
			);
		}

	}
}
