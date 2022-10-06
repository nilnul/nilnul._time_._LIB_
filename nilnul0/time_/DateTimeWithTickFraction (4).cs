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
	public partial class DateTimeWithTickFraction
		:TimeI
	{
		private DateTime _val;
		public DateTime dateTime {
			get {
				return _val;
			}
			set {
				_val = value;
			}
		}

		RealI tickFraction;

		public DateTimeWithTickFraction(DateTime dateTime,RealI tickFraction)
		{
			///tick fraction must be in [0,1)
		}


					

	}
}
