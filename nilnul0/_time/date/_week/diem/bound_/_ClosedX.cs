using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date._week.diem.bound_
{
	static public class _ClosedX
	{
		/// <summary>
		/// <see cref="nilnul.obj.IClasp"/>;
		/// </summary>
		/// <param name="begin"></param>
		/// <param name="til">
		/// <see cref="nilnul.obj.betwixt_._closed_.IEnd"/>
		/// </param>
		/// <returns></returns>
		static public IEnumerable<DayOfWeek> _Diems_1til(
			DayOfWeek begin
			,
			DayOfWeek til
		) {
			for (var i = begin; i <= til; i++)
			{
				yield return i;

			}
		}
	}
}
