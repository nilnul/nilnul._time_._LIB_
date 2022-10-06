using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime
{
	/*extern alias obj;*/
	public class Border : /*obj::*/nilnul.obj.Border<DateTime>
	{
		public Border(bool openFalseCloseTrue, DateTime mark) : base(openFalseCloseTrue, mark)
		{
		}

		static public Border CreateClose(DateTime mark) {
			return new Border(true, mark);
		}

		
	}
}
