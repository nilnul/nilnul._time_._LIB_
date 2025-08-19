using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.borel_.disjoint_
{
	/// <summary>
	/// countable union of disjoint consecutives:<see cref="consecutive_"/>. Hence empty is included when 0, a countable,  union of disjoint sets.
	/// </summary>
	/// borel is defined this way to exclude pathological cases:
	///		: uncountable but measured 0
	///		: uncountable but unmeasurable set; (note countable set is always measured 0)
	public interface IEmpty:IUnConsecutive
	{
	}
}
