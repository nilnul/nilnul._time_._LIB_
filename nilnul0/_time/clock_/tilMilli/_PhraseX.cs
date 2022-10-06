using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.clock_.tilMilli
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// this is used in ffmpeg.
	/// </remarks>
	static public class _PhraseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_timeSpan_assumeClockTilMilli"></param>
		/// <returns></returns>
		static public string _Phrase_assumeClock1TillMilli(TimeSpan _timeSpan_assumeClockTilMilli) {

			return $"{_timeSpan_assumeClockTilMilli.Hours}:{_timeSpan_assumeClockTilMilli.Minutes}:{_timeSpan_assumeClockTilMilli.Seconds}.{  _timeSpan_assumeClockTilMilli.Milliseconds.ToString().PadLeft(3,'0').TrimEnd('0')}";
		}
	}
}
