using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
	public partial class MinguoTime
		:TimeI
	{
		private uint _years;

		public MinguoTime(uint years)
		{
			this._years = years;

		}


		#region IComparable<TimeI> Members

		public int CompareTo(TimeI other)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region TimeI Members

		public Datetime dateTime
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion
	}
}
