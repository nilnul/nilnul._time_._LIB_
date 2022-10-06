using nilnul.num.real_;
using nilnul.time.seg._measure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	

	public class Unit4dblDefault<T>
		:
		nilnul.time.Duration4dbl<T>
		,
		Duration4dblI<T>
		,
		IDuration
		where T : seg._measure.Unit4dblI,new()
	{
		public Unit4dblDefault(NonnegOfDoubleI amount)
			:
			base(amount, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<T>.Instance
		)
		{
		}

	
		public Unit4dblDefault(double x)
			:base(
				 x
				 ,
nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<T>.Instance

			)
		{

		}

	}
}
