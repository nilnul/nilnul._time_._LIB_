using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{
	public class Yy2ss : nilnul.time_.datetime.PhraseA
	{

		static public string InCn(DateTime x) {

			// Create a CultureInfo object for Chinese (PRC)

			CultureInfo culture = new CultureInfo("zh-CN");


			// normally will have adjusted the application to zh-CN

			//System.Threading.Thread.CurrentThread.CurrentCulture = culture;

			//System.Threading.Thread.CurrentThread.CurrentUICulture = culture;




			return x.ToString("G", culture);

//			DateTime dt = DateTime.Now;


			//Console.WriteLine("ToString(): " + dt.ToString());

			//Console.WriteLine("ToString(format, culture): " + dt.ToString("d", culture));

			//Console.WriteLine("ToShortDateString: " + dt.ToShortDateString());

			//Console.WriteLine("ToString(\"G\", culture): " + dt.ToString("G", culture));
			//return x.ToString();
		}

		public const string FORMAT4YYMMDDHHMMSS = "yyMMddHHmmss";
		public override string phrase(DateTime obj)
		{
			return obj.ToString("yyMMdd_HHmmss" );
		}







		static public Yy2ss Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Yy2ss>.Instance;
			}
		}



	}
}
