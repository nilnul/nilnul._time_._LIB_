using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.be_
{
	public class Weekend
		: nilnul.time.BeI
	{
		public bool be(in DateTime val)
		{
			return date._week.diem.be_.Weekend.Unison.be(val.DayOfWeek);
			//throw new NotImplementedException();
		}

		public bool be(in DateTimeOffset val)
		{
			return be( val.DateTime);
			//throw new NotImplementedException();
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
