using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order;

namespace nilnul.time
{
	public partial class Order
		:TotalOrderA<DateTime>
	{

		static private readonly Order _Instance = new Order();
		static public Order Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Order()
		{
		}
				
		public override Sign compare(DateTime x, DateTime y)
		{
			return SignX.ToSign( x.CompareTo(y));
		}
	}
}
