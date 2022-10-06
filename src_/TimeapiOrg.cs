using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.src_
{
	public class TimeapiOrg
	{
		static public string GetUtcNow()
		{
			///A using statement is just syntactic sugar for a try/finally block, and as Grzenio says it's fine to return from a try block too.
			using (var client=new WebClient())
			{
				return client.DownloadString("http://www.timeapi.org/utc/now");
			}

		}
	}
}
