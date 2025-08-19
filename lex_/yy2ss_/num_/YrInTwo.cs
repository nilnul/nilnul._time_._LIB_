using nilnul.num.integer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.nonfract.lex_.num_
{
	/// <summary>
	/// non year is collapsed in pair;
	/// </summary>
	public class YrInTwo :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{

		public const string FORMAT = @"yyMMddHHmmss";
		public override string phrase(DateTime obj)
		{
			return obj.ToString(
				FORMAT
			);




		}

		public DateTime parse(string x1111)
		{
	

			return DateTime.ParseExact(x1111, FORMAT, CultureInfo.InvariantCulture
				//,DateTimeStyles.None
				);
		}


		static public YrInTwo Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<YrInTwo>.Instance;
			}
		}


	}
}
