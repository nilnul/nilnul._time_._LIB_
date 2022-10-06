using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.split.phrase_
{
	/*
		
	 
	 */
	/// <summary>
	/// 
	/// </summary>
	public class SevenDigits
		
	{
		public static string Format4Ticks = nilnul.txt.op_.RepeatX.Repeat("f", 7);
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>
		/// </returns>
		public  string phrase(DateTime obj)
		{
			var ticks=obj.ToString(Format4Ticks);
			return ticks;

			
		}




		static public SevenDigits Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SevenDigits>.Instance;
			}
		}


	}
}
