using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure
{
	
	public interface Unit4dblI :
		_unit_.AsSeconds4DblI
		,
		nilnul.obj._measure.Unit4dblI
		,
		IUnit
	{

	}
	/// <summary>
	/// second is the cannonical unit
	/// </summary>
	public class Unit4dbl :
		nilnul.obj._measure.Unit4dblA
		,
		Unit4dblI
	{
		public Unit4dbl(PositiveDbl x) : base(x)
		{
		}

		public Unit4dbl(double x) : base(x)
		{
		}

		public Unit4dbl():this(1)
		{

		}

		protected Unit4dbl(PositiveDblI val) : base(val)
		{
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
