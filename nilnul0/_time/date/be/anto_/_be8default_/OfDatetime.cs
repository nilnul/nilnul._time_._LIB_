using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.be.anto_._be8default_
{
	public class OfDatetime<T>
		: be._anto_.OfDatetime
		where T : nilnul.obj.BeI_ofIn<DateTime>, new()

	{
		public OfDatetime() : base(

			 nilnul._obj.typ_._UnisonX<T>.Unison

		)
		{
		}


		static public OfDatetime<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<OfDatetime<T>>.Unison;
			}
		}

	}
}
