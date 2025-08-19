namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	/// <summary>
	/// </summary>
	/// cannot be put together with count? incorrect|false, they can;
	static public class _IntervalX
	{
		public const string KEY = "INTERVAL";

		static public string _Texfy_0interval(int interval = 1)
		{
			return nilnul.obj.attr._PhraseX.Phrase(KEY, interval);
		}


	}
}
