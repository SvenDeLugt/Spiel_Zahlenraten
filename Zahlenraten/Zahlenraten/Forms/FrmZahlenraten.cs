using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zahlenraten.Components;

namespace Zahlenraten.Forms
{
	public partial class FrmZahlenraten : Form
	{
		public FrmNewGame FormNewGame { get; set; }
		public Exercise CurrentExercise { get; set; }

		public FrmZahlenraten()
		{
			InitializeComponent();
		}

		private void FrmZahlenraten_Load(object sender, EventArgs e) { NewGame(); }
		private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e) { NewGame(); }

		public void NewGame()
		{
			ToggleInformation(false);

			FormNewGame = new FrmNewGame();
			FormNewGame.FormMain = this;
			FormNewGame.Show();
		}

		public void StartGame()
		{
			CurrentExercise = new Exercise();
			lblExercise.Text = CurrentExercise.ExerciseString;
			txtAnswer.Text = string.Empty;

			ToggleInformation(true);

			Data.AmountExercises = 0;
			Data.AmountCorrectGuesses = 0;
			Data.AmountWrongGuesses = 0;

			UpdateInformation();
		}

		private void NewExercise()
		{
			CurrentExercise = new Exercise();
			lblExercise.Text = CurrentExercise.ExerciseString;
			txtAnswer.Text = string.Empty;
		}

		private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			CheckAnswer();
		}

		private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
				CheckAnswer();
		}


		private void CheckAnswer()
		{
			bool? correctAnswer = CurrentExercise.CheckAnswer(txtAnswer.Text);

			if (correctAnswer == null)
			{
				txtAnswer.Text = string.Empty;
				txtAnswer.Focus();
				return;
			}

			lstLastExercises.Items.Add(CurrentExercise.ExerciseString + " " + CurrentExercise.Result);
			lstLastExercises.SelectedIndex = lstLastExercises.Items.Count - 1;

			if (correctAnswer == true)
			{
				Data.AmountExercises++;
				Data.AmountCorrectGuesses++;
				NewExercise();
			}
			else
			{
				Data.AmountExercises++;
				Data.AmountWrongGuesses++;
				NewExercise();
			}

			UpdateInformation();

			if(Data.AmountExercises == Data.AmountTotalExercises)
			{
				ToggleInformation(false);

				string message = string.Format("Sie haben {0} Aufgaben beantwortet.\n\nDavon:\n{1} richtig\n{2} falsch.", Data.AmountExercises, Data.AmountCorrectGuesses, Data.AmountWrongGuesses);

				MessageBox.Show(message, "Herzlichen Glückwunsch", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lstLastExercises.Items.Clear();
				NewGame();
			}
		}

		private void UpdateInformation()
		{
			lblAmountExercises.Text = Data.AmountExercises.ToString();
			lblAmountCorrect.Text = Data.AmountCorrectGuesses.ToString();
			lblAmountWrong.Text = Data.AmountWrongGuesses.ToString();
		}

		private void ToggleInformation(bool visible)
		{
			lblExercise.Visible = visible;
			txtAnswer.Visible = visible;
			btnCheck.Visible = visible;
			lblExercisesDesc.Visible = visible;
			lblAmountExercises.Visible = visible;
			lblCorrectGuessesDesc.Visible = visible;
			lblAmountCorrect.Visible = visible;
			lblWrongGuessesDesc.Visible = visible;
			lblAmountWrong.Visible = visible;
			lblLastExercisesDesc.Visible = visible;
			lstLastExercises.Visible = visible;
		}
	}
}
