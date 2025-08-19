using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date._week.diem.be.anto_
{
	public class Be8default<TBe>
		: Anto
		where TBe : nilnul.obj.BeI_ofIn<DayOfWeek>, new()
	{
		public Be8default() : base(
			 nilnul._obj.typ_._UnisonX<TBe>.Unison
		)
		{
		}


		static public Be8default<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Be8default<TBe>>.Unison;
			}
		}

	}
}
