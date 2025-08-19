namespace nilnul.time.border_.forward_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// countable union of <see cref="forward_.IInclusive"/>;
	/// eg:
	///		the countable intersection of
	///		[1/n
	///			,where n is from 1 to inf.
	///		;Hence, 0 is never in. So it is (0
	///
	/// </remarks>
	/// alias:
	///		after
	public interface IExclusive
		:IForward
		,
		nilnul.obj.border_.lower_.IExclusive
	{
	}

}
