using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.phrase_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Separatored
		:
		date._phrase_.OfTimeI
	{

		private char? _sep;

		public char? sep
		{
			get { return _sep; }
			set { _sep = value; }
		}

		public Separatored(char? x=null)
		{
			this._sep = x;
		}
		public Separatored() : this(null)
		{
		}
		public  string phrase(DateTime obj)
		{
			return obj.ToString($"yyyy{_sep}MM{_sep}dd");
		}

		public  string _phrase_0year9month9day((int,int,int) obj)
		{
			return _phrase_0year9month9day(obj.Item1,obj.Item2,obj.Item3);
		}

		public  string _phrase_0year9month9day(int year,int month,int day)
		{
			return ($"{year.ToString("D4")}{_sep}{month.ToString("D2")}{_sep}{day.ToString("D2")}");
		}

		static public Separatored Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Separatored>.Instance;
			}
		}

	}
}
