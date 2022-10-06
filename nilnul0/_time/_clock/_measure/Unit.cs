using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._clock._measure
{
	public interface Unit4dblI:nilnul.obj._measure.Unit4dblI
	{
	}

	/// <summary>
	/// second
	/// </summary>
	public class Unit4dbl: nilnul.obj._measure.Unit4dbl,Unit4dblI
	{


		static public Unit4dbl Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Unit4dbl>.Instance;
			}
		}
		static public Unit4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unit4dbl>.Instance;
			}
		}


	}
}
