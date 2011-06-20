using System;
using System.IO;
using System.Xml.Serialization;

namespace Raytrace
{
	[Serializable]
	public class Work
	{
		[XmlAttribute]
		public int Id;
		
		[XmlAttribute]
		public bool Finished;
		
		[XmlAttribute]
		public bool HandedOut;		
		
		[XmlAttribute]
		public int ImageWidth, ImageHeight;

		[XmlAttribute]
		public int X, Y, Width, Height;
		
		public Scene Scene;		
		
		public Work ()
		{
		}
		
		public void Save (Stream w) {
			var s = new XmlSerializer(typeof(Work));
			s.Serialize (w, this);
		}
		
		public static Work Open (Stream r) {
			var s = new XmlSerializer(typeof(Work));
			return (Work)s.Deserialize (r);
		}
	}
}
