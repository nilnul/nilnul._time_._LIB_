using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.interval_.xpn_
{
	internal class IEmpty:interval_.IXpn
	{
	}


	/// <summary>
	/// <see cref="time.IInterval"/> is <see cref="time.xt.bound_"/>
	/// </summary>
	[Serializable]
	public class EmptyException : Exception
	{
		public EmptyException() { }
		public EmptyException(string message) : base(message) { }
		public EmptyException(string message, Exception inner) : base(message, inner) { }
		protected EmptyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) {

		}
	}
}
