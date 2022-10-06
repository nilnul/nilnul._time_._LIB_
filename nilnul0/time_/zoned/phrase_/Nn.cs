using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.zoned.phrase_
{
	/// <summary>
	/// nilnul negative nontraditional notation.
	/// eg: 21/09/01n8:00-7:00 means east 7 timezone.
	///		8:00n7:00, means east 7 timezone.
	///		
	/// 
	/// nn means NilNul. we can have nilnul only at the begining according to nilnul.dev. so we use nn here to refer to "nilnul"
	/// we use "-", not "+" for east timezones, thus 20:00-8:00 (20:00 beijing time) can be interpreted as math minus to get the standard greanwich mean time: 12:00.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// use n for negtive,
	/// for positive, use
	///		N
	///			nonneg? natural?
	///		p
	///		P
	static public class _NnX
	{
		static public string Phrase(DateTimeOffset zoned) {
			return $"{zoned.DateTime}-{zoned.Offset}";
		}
	}
}
