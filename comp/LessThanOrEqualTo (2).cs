using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order;

namespace nilnul.time.order
{
	public partial class LessThanOrEqualTo
		:nilnul.order.total.finite.OrderI<DateTime>
		
		
	{

		public LessThanOrEqualTo()
		{
		}
				
	

		public bool contains(DateTime first, DateTime second)
		{
			return first.CompareTo(second) <= 0;
			throw new NotImplementedException();
		}

		public DateTime maximum
		{
			get {
				return DateTime.MaxValue;
				
				throw new NotImplementedException(); }
		}

		public DateTime minimum
		{
			get {
				return DateTime.MinValue;
				
				throw new NotImplementedException(); }
		}
	}
}
