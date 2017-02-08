using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zahlenraten.Utils;

namespace Zahlenraten.Components
{
	public class Exercise
	{
		public BigInteger FirstNumber { get; private set; }
		public BigInteger SecondNumber { get; private set; }
		public BigInteger Result { get; private set; }
		public string ExerciseString { get; private set; }

		private Random random;

		public Exercise()
		{
			random = new Random();

			FirstNumber = random.Next((int)Data.MinValue, (int)Data.MaxValue + 1);
			SecondNumber = random.Next((int)Data.MinValue, (int)Data.MaxValue + 1);

			bool availableExerciseType = false;
			int operatorIndex;

			do
			{
				operatorIndex = random.Next(0, (int)OperationType.Modulo + 1);

				if (Data.AdditionChecked && (OperationType)operatorIndex == OperationType.Addition) availableExerciseType = true;
				if (Data.SubtractionChecked && (OperationType)operatorIndex == OperationType.Subtraction) availableExerciseType = true;
				if (Data.MultiplicationChecked && (OperationType)operatorIndex == OperationType.Multiplication) availableExerciseType = true;
				if (Data.DivisionChecked && (OperationType)operatorIndex == OperationType.Division) availableExerciseType = true;
				if (Data.ModuloChecked && (OperationType)operatorIndex == OperationType.Modulo) availableExerciseType = true;
			}
			while (!availableExerciseType);
			
			switch ((OperationType)operatorIndex)
			{
				case OperationType.Addition:
					Result = FirstNumber + SecondNumber;
					ExerciseString = string.Format("{0} + {1} =", FirstNumber, SecondNumber);
					break;
				case OperationType.Subtraction:
					Result = FirstNumber - SecondNumber;

					if (!Data.NegativesAllowed && Result < 0)
					{
						bool isNegative = true;

						while (isNegative)
						{
							SecondNumber = random.Next((int)Data.MinValue, (int)Data.MaxValue);

							BigInteger tempresult = FirstNumber - SecondNumber;

							if (tempresult < 0)
								isNegative = true;
							else
							{
								isNegative = false;
								Result = tempresult;
							}
						}
					}
					
					ExerciseString = string.Format("{0} - {1} =", FirstNumber, SecondNumber);
					break;
				case OperationType.Multiplication:
					Result = FirstNumber * SecondNumber;
					ExerciseString = string.Format("{0} * {1} =", FirstNumber, SecondNumber);
					break;
				case OperationType.Division:
					if (SecondNumber == 0) SecondNumber = random.Next(1, (int)Data.MaxValue + 1);
					Result = FirstNumber / SecondNumber;
					ExerciseString = string.Format("{0} / {1} =", FirstNumber, SecondNumber);
					break;
				case OperationType.Modulo:
					Result = FirstNumber % SecondNumber;
					ExerciseString = string.Format("{0} % {1} =", FirstNumber, SecondNumber);
					break;
			}
		}

		public bool? CheckAnswer(string guessString)
		{
			BigInteger guess;
			
			try
			{
				guess = BigInteger.Parse(guessString);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}

			if (guess == Result)
			{
				// Die Antwort ist richtig
				return true;
			}
			else
			{
				// Die Antwort ist falsch
				return false;
			}
		}
	}
}
