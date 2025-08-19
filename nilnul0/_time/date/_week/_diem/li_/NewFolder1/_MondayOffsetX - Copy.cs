using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date._week.li_
{
	/// <summary>
	/// 0 means monday, 4 means friday,  6 means sunday.
	/// </summary>
	static public class _MondayOffsetX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dayOfWeek"></param>
		/// <returns>
		/// sunday offset
		/// </returns>
		public static int FroSundayOffset( int dayOfWeek)
		{
			return	(
				dayOfWeek       //[0,6]
				- 1             // monday based   //  to [-1,5]
				+ 7  //make it positive  // [6,12]
			) % 7 // make it in [0,6], where 0 means monday.
			; 
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dayOfWeek"></param>
		/// <returns>
		/// sunday offset
		/// </returns>
		public static int FroSundayOffset( DayOfWeek dayOfWeek)
		{
			return FroSundayOffset( (int) dayOfWeek) ; 
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mondayOffset">0 means monday</param>
		/// <returns>
		/// 0 means sunday
		/// </returns>
		public static int ToSundayOffset_0modayOffset( int mondayOffset)
		{
			return	(mondayOffset -6//sunday
				+7)%7
			; 
		}

		public static DayOfWeek ToDayOfWeek_0mondayOffset( int mondayOffset)
		{
			return	(DayOfWeek)ToSundayOffset_0modayOffset(mondayOffset)
			; 
		}


	}
}
