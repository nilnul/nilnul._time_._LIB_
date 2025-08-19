namespace nilnul.time
{

	/// <summary>
	/// between two points. no direction.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		span
	///		tend
	///		neighbor
	///			but in 2d, a neighbor is not linear, but a disc.
	///		seg,
	///			like "set",implying the two end points have no particular order
	///		tend
	/// alias:
	///		<see cref="nilnul.obj.IClosure"/>
	///		<see cref="nilnul.obj.IClasp"/>
	///		clamp
	///		period
	public interface ITend
		:
		bound_.IClosed
	{
	}

}
