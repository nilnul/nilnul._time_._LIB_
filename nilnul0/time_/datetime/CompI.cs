using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime
{
	public interface CompI:IComparer<DateTime>
	{
	}

	public class Comp : CompI
	{
		public int Compare(DateTime x, DateTime y)
		{
			return Comparer<DateTime>.Default.Compare(x, y);
			throw new NotImplementedException();
		}

		static public Comp Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Comp>.Instance;
			}
		}

	}
}
