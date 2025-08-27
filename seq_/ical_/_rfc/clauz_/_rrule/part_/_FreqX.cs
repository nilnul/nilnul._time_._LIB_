namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	static public class _FreqX
	{
		static public string KEY = "FREQ";
		static public string Texfy(string freq) {
			return nilnul.obj.attr._PhraseX.Phrase(
				KEY
				,
				freq
			);
		}
		static public string Texfy(Freq freq) {
			return Texfy(
				freq.ToString().ToUpperInvariant()
			);
		}


	}
}
