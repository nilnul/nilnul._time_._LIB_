using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.cosmo.time
{
	public partial class Year
		
	{
		public int year { get; set; }
		public Year(int year)
		{
			this.year = year;
		}


		#region VariableI<TimeI> Members

		public nilnul.element.collection.set.SetI<TimeI> range
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

		public string name
		{
			get { throw new NotImplementedException(); }
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

		#region IComparable<TimeI> Members

		public int CompareTo(TimeI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
