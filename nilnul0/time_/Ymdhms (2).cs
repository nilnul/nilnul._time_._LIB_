using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.time
{
	public partial struct Ymdhms
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// 

		public Ymdhms(string s)
		{
			//parse the string.
			var m=Regex.Match(s.Trim());
			_ad = m.Groups["bc"].Value != "";
			_year =int.Parse( m.Groups["year"].Value);
			_month = byte.Parse(m.Groups["month"].Value);
			_date = byte.Parse(m.Groups["date"].Value);
			_hour= byte.Parse(m.Groups["hour"].Value);
			_minute= byte.Parse(m.Groups["minute"].Value);
			_second= byte.Parse(m.Groups["second"].Value);
		}

		static public Regex Regex = new Regex(
			@"
					(?<bc>
						-
					)?



					(?<year>
						(?:\d{2}) | (?:\d{4})
					)
					(?<dateSep>
						[._#\\\/-]
					)
					(?<month>
						(?:0?[1-9]) |  (?:1[012])		#month
					)
					\k<dateSep>
#################
#(?-<dateSep>)
					(?<date>
						(?:[0]?[1-9])| (?:[12][0-9]) | (?:3[01])
					)
					(?:
				
						(?:\s+|[&@*_+,;#])	#seperator between date and time
						(?<hour>
							(?:[01]?[0-9])|(?:2[0-3])
						)
						:
						(?<minute>
							(?:(?:0?|[1-5])[0-9]) 
						)
						(?:
							:
							(?<second>
								(?:[0-5]?[0-9])
							)
						)?
					)?
					
				"

			, RegexOptions.IgnorePatternWhitespace

		);

		private bool _ad;

		public bool ad
		{
			get { return _ad; }
			set { _ad = value; }
		}
		
					


		private int _year;

		public int year
		{
			get { return _year; }
			set { _year = value; }
		}
		private byte? _month;

		public byte? month
		{
			get { return _month; }
			set { _month = value; }
		}

		private byte? _date;

		public byte? date
		{
			get { return _date; }
			set { _date = value; }
		}

		private byte? _hour;

		public byte? hour
		{
			get { return _hour; }
			set { _hour = value; }
		}

		private byte? _minute;

		public byte? minute
		{
			get { return _minute; }
			set { _minute = value; }
		}

		private byte _second;

		public byte second
		{
			get { return _second; }
			set { _second = value; }
		}
		
		
		
	}
}
