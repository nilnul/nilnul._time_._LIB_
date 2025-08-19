using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul._time.date._week
{
	/// <summary>
	/// all
	/// </summary>
	/// vs:
	///		weekday, which means <see cref=""/>
	static public class _DiemsX
	{

		static public IEnumerable< DayOfWeek> _Diems {
			get {
				for (DayOfWeek i = DayOfWeek.Sunday; i <= DayOfWeek.Saturday; i++)
				{
					yield return i;
				}
			}
		}

		static public readonly DayOfWeek[] Diems =_Diems.ToArray();
	}

}
