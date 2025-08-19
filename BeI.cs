using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time
{
	public interface BeI:_be_.OfDatetimeI
		,
		_be_.OfZonedI
	{
	}

	public abstract class BeA : BeI
	{
		public abstract bool be(in DateTime val);
		public bool be(in DateTimeOffset val) {
			return be(val.LocalDateTime);
		}
	}
}
