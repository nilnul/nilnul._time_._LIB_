using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.phrase_.num_
{

	/// <summary>
	/// year in four digits;
	/// eg: 20241106
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class YearInFour
		//: nilnul.time_.datetime.PhraseA
		//,nilnul.time_.datetime.ParseI
	{




		public const string FORMAT= "yyyyMMdd";


		public static string Format = FORMAT;

		public  string phrase(DateTime obj)
		{
			return obj.ToString(Format);
		}

	

		static public YearInFour Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<YearInFour>.Unison;
			}
		}

	}
}
