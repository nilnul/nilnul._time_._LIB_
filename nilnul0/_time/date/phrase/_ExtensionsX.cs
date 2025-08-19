using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.phrase
{
	static public class _ExtensionsX
	{
		static public string Phrase(this date._phrase_.OfTimeI phraser) {
			return phraser.phrase(DateTime.Now);
		}
	}
}
