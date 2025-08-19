using System.Runtime.CompilerServices;

namespace nilnul._time.date.txten_.num_
{
	static public class _YearInFourX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Txten_0year9month9day((int, int, int) obj)
		{
			return _Txten_0year9month9day(obj.Item1, obj.Item2, obj.Item3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Txten_0year9month9day(int year, int month, int day)
		{
			return ($"{year.ToString("D4")}{month.ToString("D2")}{day.ToString("D2")}");
		}


	}
}
