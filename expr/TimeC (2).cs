using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nilnul.time
{
	public partial class TimeC : UserControl
	{
		public TimeI time
		{
			get;
			set;
		}
		public TimeC()
		{
			InitializeComponent();
		}

		private void TimeC_Load(object sender, EventArgs e)
		{
			
			label1.Text = time.ToString();
			
		}

		private void TimeC_Enter(object sender, EventArgs e)
		{

		}
	}
}
