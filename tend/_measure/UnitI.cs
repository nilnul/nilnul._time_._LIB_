using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure
{
	public interface IUnit :
		nilnul.obj._measure.IUnit
	{

	}
	public interface UnitI :
		_unit_.AsSecondsI
		,
		IUnit
	//,
	//nilnul.obj._measure.Unit4dblI
	{
	}
	/// <summary>
	/// second is the cannonical unit
	/// </summary>
	public class Unit :
		nilnul.obj._measure.UnitA,

		UnitI
	{
		protected Unit(PositiveI val) : base(val)
		{
		}
		public Unit(RealI mag) : this(
new nilnul.num.real_.Positive(
				mag
			)
		)
		{
		}
		public Unit() : this(
			(
				new nilnul.num.real_.Quotient(1)
			)
		)
		{

		}


		static public Unit Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Unit>.Instance;
			}
		}

		//public PositiveI magnitude => throw new NotImplementedException();
	}
}
