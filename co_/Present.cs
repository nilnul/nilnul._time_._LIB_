using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.co_
{
	static public class _PresentX
	{
		static public (DateTime anchor, DateTime end) _Co_0nonpos4past_1pos4future( int nonpos=-11, int pos=11) {
			var now = DateTime.Now;
			return (now.AddDays(nonpos),now.AddDays(pos));

		}

	}
}
