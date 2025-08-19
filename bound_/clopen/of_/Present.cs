using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bound_.clopen_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		present
	///			,analog to "past"
	///	vs:
	///		future
	///		immediate
	///		imminent, next
	///	<see cref="nilnul._time.date.op_.weeky_._ImminentX"/>
	static public class _PresentX
	{
		public const int NONPOS4PAST = -11;
		public const int POS4FUTURE = 11;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="nonpos">default:one and a bigger half of a week</param>
		/// <param name="pos">default:one and a bigger half of a week</param>
		/// <returns></returns>
		static public (DateTime anchor, DateTime end) _Co_0nonpos4past_1pos4future(
			int nonpos=NONPOS4PAST, int pos=POS4FUTURE
		) {
			var now = DateTime.Now;
			return (now.AddDays(nonpos),now.AddDays(pos));

		}

		static public (DateTime anchor, DateTime end) _Co_0pos4radius(
			 int pos4radius=POS4FUTURE
		) {
			return _Co_0nonpos4past_1pos4future(-pos4radius, pos4radius);

		}

		static public (DateTime anchor, DateTime end) _Hence_0pos4future(
			 int pos=POS4FUTURE
		) {
			return _Co_0nonpos4past_1pos4future(0, pos);

		}




	}
}
