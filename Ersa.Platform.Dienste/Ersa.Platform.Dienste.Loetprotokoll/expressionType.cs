using System;
using System.Xml.Serialization;

namespace Ersa.Platform.Dienste.Loetprotokoll
{
	[Serializable]
	public class expressionType
	{
		[XmlAttribute]
		public string name
		{
			get;
			set;
		}
	}
}
