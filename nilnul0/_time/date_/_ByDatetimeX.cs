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
		///
		[Obsolete( "directly use DateTime.Now.Date")]
		static public DateTime Today() {
			return DateTime.Now.Date;
			
		}
		static public DateTime Tomorrow() {
			return DateTime.Now.Date.AddDays(1);
			
		}
		static public DateTime Overmorrow() {
			return DateTime.Now.Date.AddDays(2);
			
		}

		[Obsolete(nameof(Overmorrow) + " is preferred as it's only one word,but grammatically correct and charming inspite of being somewhat archaic;")]
		static public DateTime DayAfterTomorrow() {
			return DateTime.Now.Date.AddDays(2);
			
		}



	}
}
