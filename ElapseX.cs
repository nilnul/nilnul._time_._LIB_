using System;
using System.Net;
using System.Windows;

namespace nilnul.time
{
	static public  class ElapseX
	{
		static public double Divide(this System.TimeSpan a, System.TimeSpan b) {

			
			return ( (double)(a.Ticks)) / b.Ticks;
		}


		static public TimeSpan Multiply(this TimeSpan a, int b) {
			return new TimeSpan((a.Ticks * b));
		
		}
		

	}


}
