using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_._zoned.zone_
{
	internal class Zero
	{
		/// <summary>
		/// per:
		///		datatracker.ietf.org/doc/html/rfc3339#section-5
		///	; means +00:00
		/// </summary>
		/// <remarks>
		/// NOTE: Per [ABNF] and ISO8601, the "T" and "Z" characters in this		syntax may alternatively be lower case "t" or "z" respectively.
		/// ISO 8601 defines date and time separated by "T".      Applications using this syntax may choose, for the sake of      readability, to specify a full-date and full-time separated by      (say) a space character.
		/// but in practice, the 't' is seldomly used;
	/// </remarks>
		public const char ENDING = 'Z';
	}
}
