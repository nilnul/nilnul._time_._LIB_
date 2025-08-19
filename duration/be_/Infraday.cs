using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		<see cref="time.re_.Intraday"/>
	///		supraday
	///		ultraday
	public class Infraday
		: nilnul.time.duration._be_.OfTimespanI
	{
		static public readonly TimeSpan SUPERMUM = TimeSpan.FromDays(1);


		public bool _be_0nonneg(TimeSpan span)
		{
			return span < SUPERMUM;
			///throw new NotImplementedException();
		}

		static public Infraday Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Infraday>.Instance;
			}
		}

	}
}
