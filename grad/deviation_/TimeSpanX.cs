using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace nilnul.time
{
	static public partial class TimeSpanX
	{
		static public double Divide(this System.TimeSpan a, System.TimeSpan b) {

			
			return ( (double)(a.Ticks)) / b.Ticks;
		}


		static public TimeSpan Multiply(this TimeSpan a, int b) {
			return new TimeSpan((a.Ticks * b));
		
		}
		

	}


}
