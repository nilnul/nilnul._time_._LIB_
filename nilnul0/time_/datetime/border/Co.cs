using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.time_.datetime.border
{
	public class Co : nilnul.obj.border.Duo<DateTime, nilnul.time_.datetime.Border>
	{
		private obj.Border<DateTime> border1;
		private obj.Border<DateTime> border2;

		

		public Co(Border item1, Border item2) : base(item1, item2)
		{
		}

		public static Co CreateClose(DateTime left, DateTime right) {
			return new Co(  Border.CreateClose(left), Border.CreateClose(right));
		}
	}
}
