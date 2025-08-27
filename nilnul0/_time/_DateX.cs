using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._time
{

	static public  class _DateX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="time"></param>
		/// <param name="seperator"></param>
		/// <param name="yearInTwoDigitsOrFour"></param>
		/// <returns></returns>
		static public string Txten(
			DateTime time
			,
			string seperator="" //between date and clock
			,
			bool yearInTwoDigitsOrFour=true
			
			) {
				return time.ToString(
					string.Format(	
						"{0}{1}MM{1}dd"
						,yearInTwoDigitsOrFour?"yy":"yyyy"
						, "'"+seperator+"'"

					)			//http://msdn.microsoft.com/zh-cn/library/vstudio/8kb3ddd4(v=vs.100).aspx 自定义日期和时间格式字符串
					
				);


		
		}
	}
}
