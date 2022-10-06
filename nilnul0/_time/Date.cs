using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
	public partial class Date
	{
		static public string ToStr(
			DateTime time
			,
			string seperator=""
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
