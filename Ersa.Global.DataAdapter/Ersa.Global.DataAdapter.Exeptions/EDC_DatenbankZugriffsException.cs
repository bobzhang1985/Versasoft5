using System;

namespace Ersa.Global.DataAdapter.Exeptions
{
	public class EDC_DatenbankZugriffsException : Exception
	{
		public EDC_DatenbankZugriffsException()
		{
		}

		public EDC_DatenbankZugriffsException(string i_strMeldung)
			: base(i_strMeldung)
		{
		}

		public EDC_DatenbankZugriffsException(string i_strMeldung, Exception i_fdcInnerExeption)
			: base(i_strMeldung, i_fdcInnerExeption)
		{
		}
	}
}
