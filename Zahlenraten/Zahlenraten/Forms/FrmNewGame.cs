using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenraten.Forms
{
	public partial class FrmNewGame : Form
	{
		public FrmZahlenraten FormMain { get; set; }

		public FrmNewGame()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			if (CheckInput())
			{
				FormMain.StartGame();
				Close();
			}
			else
			{
				return;
			}
		}

		private bool CheckInput()
		{
			bool inputCorrect = true;

			// Prüfen, ob Benutzername gültig ist
			if (txtUsername.Text.Length >= 2) Data.Username = txtUsername.Text;
			else
			{
				MessageBox.Show("Bitte geben Sie einen Namen ein, der länger als 2 Zeichen ist!", "Ungültiger Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				inputCorrect = false;
			}

			if(!chkAddition.Checked && !chkSubtraction.Checked && !chkMultiplication.Checked && !chkDivision.Checked && !chkModulo.Checked)
			{
				MessageBox.Show("Bitte wählen Sie eine Rechenoperation aus.", "Keine Rechenoperation gewählt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				inputCorrect = false;
			}
			else
			{
				Data.AdditionChecked = chkAddition.Checked;
				Data.SubtractionChecked = chkSubtraction.Checked;
				Data.MultiplicationChecked = chkMultiplication.Checked;
				Data.DivisionChecked = chkDivision.Checked;
				Data.ModuloChecked = chkModulo.Checked;
				
			}

			Data.MinValue = (BigInteger)nudMinValue.Value;
			Data.MaxValue = (BigInteger)nudMaxValue.Value;
			Data.AmountTotalExercises = (int)nudAmountExercises.Value;
			Data.NegativesAllowed = chkAllowNegatives.Checked;

			return inputCorrect;
		}

		private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Return)
			{
				btnOkay_Click(sender, e);
			}
		}
	}
}
