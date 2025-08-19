using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bi_
{

	public interface IMin :nilnul.time.IBi{ }
	static public class _MinX
	{
		static public DateTime Min(DateTime a, DateTime b) {
			return a > b ? b : a;
		}


	}

}
