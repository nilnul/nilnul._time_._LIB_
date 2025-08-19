using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.border_.backward_
{
	/// <summary>
	/// countable intersection of <see cref="backward_.IExclusive"/>
	/// ;eg:
	///		for n from 1 to infinity
	///		, (-inf, 1/n)
	///		, it's equivalent to (-inf,0], as any positive number is not in that intersected.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		final
	///		deadline
	public interface IInclusive:IBackward
	{
	}
}
