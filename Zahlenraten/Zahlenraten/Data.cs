using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Zahlenraten.Utils;

namespace Zahlenraten
{
	public static class Data
	{
		public static string Username { get; set; }

		public static BigInteger MinValue { get; set; }
		public static BigInteger MaxValue { get; set; }

		public static bool AdditionChecked { get; set; }
		public static bool SubtractionChecked { get; set; }
		public static bool MultiplicationChecked { get; set; }
		public static bool DivisionChecked { get; set; }
		public static bool ModuloChecked { get; set; }

		public static int AmountExercises { get; set; }
		public static int AmountCorrectGuesses { get; set; }
		public static int AmountWrongGuesses { get; set; }

		public static int AmountTotalExercises { get; set; }

		public static bool NegativesAllowed { get; set; }
	}
}
