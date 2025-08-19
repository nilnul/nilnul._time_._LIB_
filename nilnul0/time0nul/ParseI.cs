using System;

namespace nilnul.time0nul
{
	public interface ParseI
		: nilnul.obj.ParseI<DateTime?>
	{
	}

	static public class _ParseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">
		///eg:
		///	2099/11/11
		/// </param>
		/// <returns>
		/// the offset would be defautled to the local one.
		/// </returns>
		static public DateTimeOffset? ParseAsLocalOffset(string s)
		{

			return DateTimeOffset.TryParse(s, out var benchmark) ? benchmark : null;

			
		}
	}
}