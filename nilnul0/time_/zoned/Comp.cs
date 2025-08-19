using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.zoned
{
	public class Comp
		: IComparer<DateTimeOffset>
	{
		public int Compare(DateTimeOffset x, DateTimeOffset y)
		{
			return x.CompareTo(y);

		}

		static public Comp Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Comp>.Unison;
			}
		}

	}
}
