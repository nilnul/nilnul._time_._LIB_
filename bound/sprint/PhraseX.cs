using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bound.sprint
{
	/// <summary>
	/// 
	/// </summary>
	internal class _PhraseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="deed">
		/// <see cref="nilnul.txt_.word_.INub"/>
		/// <see cref="nilnul.txt_.sn_.INob"/>
		/// </param>
		/// <param name="startTime">
		///
		/// </param>
		/// <returns></returns>
		static public string _PhraseTilSecond_0nob(string deed, DateTime startTime) {
			return $"{deed}{
				startTime.ToString("yyMMddHHmmss")
			}";
		}
	}
}
