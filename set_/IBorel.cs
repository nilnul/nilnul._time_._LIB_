using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.set_
{
	/// <summary>
	/// countable union/intersection/complement of <see cref="time.IBound"/>
	/// ; hence this includes intervals that has  (-inf, inf) 
	/// </summary>
	public interface IBorel:IMeasurable
	{
	}
}
