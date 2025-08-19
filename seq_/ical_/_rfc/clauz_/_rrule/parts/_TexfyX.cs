using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.parts
{

    static public class _TexfyX
    {
		/// <summary>
		/// no ending semicolon as that indicates a sentence but this is an expr, not sentence;
		/// </summary>
		/// <param name="parts"></param>
		/// <returns></returns>
		static public string _Texfy_0parts(
			IEnumerable<string> parts
		) {
			return string.Join( ";", parts );
		}

		static public string _Texfy_0parts(
			 params string[] parts
		) {
			return _Texfy_0parts( (IEnumerable<string>) parts );
		}


    }
}
