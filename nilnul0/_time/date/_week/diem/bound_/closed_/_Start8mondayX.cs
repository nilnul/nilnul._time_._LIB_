using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date._week.diem.bound_.closed_
{
	static public class _Start8mondayX
	{
		/// <see cref="nilnul.obj.IClasp"/>;
		/// <summary>
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

			return nilnul.num.integer.bound_._Closed1nX._Seq_1tilLtMax(
				_diem.li_._MondayOffsetX.FroSundayOffset(begin)
				,
				_diem.li_._MondayOffsetX.FroSundayOffset(til)

			).Select(
				i=> _diem.li_._MondayOffsetX.ToDayOfWeek_0mondayOffset(i)
			);

	
		}
	}
}
