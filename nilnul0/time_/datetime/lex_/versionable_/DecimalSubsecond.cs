using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime._lex_.phrase_.yr_
{
	/// <summary>
	/// subseconds, or fractional, or noninteger seconds, is denoted by decimal mantissa.
	/// eg:
	///  2022y1m3d2h3i5.0777s
	///		=2022y1m3d2h3i5_0777s		# avoided '.', which is unallowed in Id
	///		=2022y1m3d2h3i5s0777		# avoided '_', which can be lifted as a higher order separator.
	///		=2022y1m3d2h3S5s0777		# use 'S' to start seconds, implicitly meaning precedent is minute.
	///		
	/// </summary>
	public interface IDecimalSubsecond
		:IYrInTwoDigits
	{ }
	/// <summary>
	/// </summary>
	public class DecimalSubsecond
		:
		nilnul.time_.datetime.PhraseA
		//,
		//nilnul.time_.datetime._lex_._phrase_.OfOffsetI
		,
		IDecimalSubsecond
	{

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// eg:
		///		s
		///			ending of second as the measure unit, begining split second. this acts as a decimal point.
		///			the sep can be "", "_", "S", or "s"
		/// </remarks>
		private string _sep;

		public string sep
		{
			get { return _sep; }
			set { _sep = value; }
		}
		public DecimalSubsecond(string sep0="s")
		{
			_sep = sep0;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>
		/// eg:
		///		210702145300S00125
		/// </returns>
		public override string phrase(DateTime obj/*=DateTime.UtcNow*/)
		{
			


			var tilSeconds = obj.ToString(nilnul.time_.datetime.phrase_.Yy2ss.FORMAT4YYMMDDHHMMSS);

			var ticksTrimmed=split.phrase_.TrimEnd.Singleton.phrase(obj);
			if (ticksTrimmed == string.Empty)
			{
				return tilSeconds;//todo: remove trailing nils in hourMinutSecond; note the nil in "10" is not removable. the date can also be trimed (of day 01,month 01, as day or month is one-based)
			}

			return $"{tilSeconds}{this._sep}{ticksTrimmed}";	//point is not allowed, so we use "_". or we can use "S", or "s".
		}

		/// <summary>
		/// used in ver.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public string phraseUseLetter(DateTimeOffset obj)
		{
			//if (obj.Offset.TotalSeconds ==0)
			//{
			//	/// we better remove the zone info, or we can just append a 'n'
			//}

			return $@"{phrase(obj.DateTime )}{
				time_._zoned.zone_.span.phrase_.Verable_subsecondsAsMantissa.Singleton.phrase(obj.Offset)
			}";
			//throw new NotImplementedException();
		}

		//public string phraseUseNeg(DateTimeOffset obj)
		//{

		//	return $"{phrase(  obj.DateTime )}-{obj.Offset}";
		//	//throw new NotImplementedException();
		//}

	}
}
