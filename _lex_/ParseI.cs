using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time._lex_
{
	/// <summary>
	/// unlike <see cref="time_.datetime.PhraseI"/>, here we suppose the time is in arbitrary precision, hence we need to consider the frational second of arbitrary lenght, such as 0.000134second.
	/// Thus we cannot have a preset measure with using an integer.We need to turn to mantissa/fractional decimal.
	/// eg:
	///		22y12m12d220308.0053546
	///			which means year 22, month12, day#12, 22clock, minute3,second8, and 0.0053546seconds.
	///	when we cannot use "." such as <see cref="nilnul.obj.IId"/>, we can alternate with:
	///		-) '_'
	///		-) no separtor. 22y12m12d2203080053546 is interpreted as 22y12m12d220308  0053546
	///			-) or use letter: 22y12m12d220308s0053546
	/// </summary>
	public interface ParseI
		:nilnul.obj.ParseI<DateTime>
	{
	}
}
