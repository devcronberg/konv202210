using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    internal class Hund
    {
		private int antalBen;

		public int AntalBen
		{
			get { return antalBen; }
			set { antalBen = value; }
		}

		private string navn;

		public string Navn
		{
			get { return navn; }
			set { navn = value; }
		}

		private System.Drawing.Color color;

		public System.Drawing.Color Color
		{
			get { return color; }
			set { color = value; }
		}


	}

	class Fugl {

		public string Navn { get; set; }
		//public int AntalVinger { get; set; }
		private int antalVinger;

		public int AntalVinger
		{
			get { return antalVinger; }
			set {
				if (value < 0)
					throw new Exception("alkdjf");
				antalVinger = value; }
		}

		public bool ErILive { get; set; }



	}
}
