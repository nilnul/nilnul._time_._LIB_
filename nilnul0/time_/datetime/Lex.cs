using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime
{
	public interface LexI
		:
		nilnul.obj.LexI<DateTime>
	{
	}

	public abstract class LexA:LexI {
		public abstract DateTime parse(string x);

		public string phrase(DateTimeOffset datetime)
		{
			return phrase(datetime.ToUniversalTime().DateTime);
		}
		public string phrase()
		{
			return phrase(DateTime.UtcNow);
		}

		public abstract string phrase(DateTime obj);
	}
}
