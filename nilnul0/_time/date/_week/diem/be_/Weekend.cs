using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date._week.diem.be_
{
	public class Weekend
		:
		nilnul.obj.BeI_ofIn<DayOfWeek>
	{
		public bool be(in DayOfWeek val)
		{
			return val == DayOfWeek.Saturday || val == DayOfWeek.Sunday;
		}


		static public Weekend Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Weekend>.Unison;
			}
		}

	}
}
