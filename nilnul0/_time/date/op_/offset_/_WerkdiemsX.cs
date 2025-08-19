using System;
using System.Diagnostics;

namespace nilnul._time.date.op_.offset_
{
	static public class _WerkdiemsX
	{
		/// <summary>
		/// the begin, if a werkday, is counted as part of the offset.
		/// the returned is a werkday, and is counted within the offset. the next day might be werkday or weekend;
		/// </summary>
		/// <param name="begin">
		/// counted inclusive;
		/// </param>
		/// <param name="offsetPositive"></param>
		/// <returns></returns>
		static public DateTime _EndAt_1positive(DateTime begin, int offsetPositive)
		{
			DateTime i = begin;
			for (  ; ; i=i.AddDays(1))
			{
				
				/*
				 china.huanqiu.com/article/4AnUavuYcGe

8日，国务院办公厅发布关于2023年部分节假日安排的通知。经国务院批准，2023年元旦、春节、清明节、劳动节、端午节、中秋节和国庆节放假调休日期的具体安排通知如下：

元旦：2022年12月31日至2023年1月2日放假调休，共3天。

春节：1月21日至27日放假调休，共7天。1月28日（星期六）、1月29日（星期日）上班。

清明节：4月5日放假，共1天。

劳动节：4月29日至5月3日放假调休，共5天。4月23日（星期日）、5月6日（星期六）上班。

端午节：6月22日至24日放假调休，共3天。6月25日（星期日）上班。

中秋节、国庆节：9月29日至10月6日放假调休，共8天。10月7日（星期六）、10月8日（星期日）上班。

				 */
				if (
					nilnul._time.date._week.diem.be_.NonWeekend.Unison.be( i.DayOfWeek  )
				)
				{
					offsetPositive --;
					if (offsetPositive ==0)
					{
						break;	/// end a werkday
					}

				}
			}

			return i;
			///// 

			//Debug.WriteLine(
			//	i 
			//);
		}
	}
}
