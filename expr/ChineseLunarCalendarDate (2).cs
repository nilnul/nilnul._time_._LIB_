using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace nilnul.time
{
	public partial class ChineseLunarCalendarDate
	{
		public int? year { get; set; }
		public int? month
		{
			get;
			set;
		}
		public int? day { get; set; }

		static public Regex regex
		{
			get {
				return new Regex(
					@"
						\d{0,4}
						(?seper:\.|\-)
						\d{0,2}
						(?sep)
						\d{0,2}
							
					"
					,RegexOptions.IgnorePatternWhitespace
				);
			}
		}
		

		public ChineseLunarCalendarDate(string str)
		{
			
			
		}
					
	}
}
