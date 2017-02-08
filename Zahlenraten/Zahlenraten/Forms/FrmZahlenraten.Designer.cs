namespace Zahlenraten.Forms
{
	partial class FrmZahlenraten
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblExercise = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lblExercisesDesc = new System.Windows.Forms.Label();
			this.lblCorrectGuessesDesc = new System.Windows.Forms.Label();
			this.lblWrongGuessesDesc = new System.Windows.Forms.Label();
			this.lblAmountExercises = new System.Windows.Forms.Label();
			this.lblAmountCorrect = new System.Windows.Forms.Label();
			this.lblAmountWrong = new System.Windows.Forms.Label();
			this.lstLastExercises = new System.Windows.Forms.ListBox();
			this.lblLastExercisesDesc = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(550, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// spielToolStripMenuItem
			// 
			this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.beendenToolStripMenuItem});
			this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
			this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.spielToolStripMenuItem.Text = "Spiel";
			// 
			// neuesSpielToolStripMenuItem
			// 
			this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
			this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.neuesSpielToolStripMenuItem.Text = "Neues Spiel...";
			this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// lblExercise
			// 
			this.lblExercise.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExercise.Location = new System.Drawing.Point(12, 33);
			this.lblExercise.Name = "lblExercise";
			this.lblExercise.Size = new System.Drawing.Size(275, 31);
			this.lblExercise.TabIndex = 1;
			this.lblExercise.Text = "0 + 0 =";
			this.lblExercise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAnswer
			// 
			this.txtAnswer.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer.Location = new System.Drawing.Point(293, 34);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(131, 31);
			this.txtAnswer.TabIndex = 2;
			this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(430, 34);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(107, 31);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Raten";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// lblExercisesDesc
			// 
			this.lblExercisesDesc.AutoSize = true;
			this.lblExercisesDesc.Location = new System.Drawing.Point(13, 74);
			this.lblExercisesDesc.Name = "lblExercisesDesc";
			this.lblExercisesDesc.Padding = new System.Windows.Forms.Padding(5);
			this.lblExercisesDesc.Size = new System.Drawing.Size(101, 23);
			this.lblExercisesDesc.TabIndex = 4;
			this.lblExercisesDesc.Text = "Anzahl Aufgaben:";
			// 
			// lblCorrectGuessesDesc
			// 
			this.lblCorrectGuessesDesc.AutoSize = true;
			this.lblCorrectGuessesDesc.Location = new System.Drawing.Point(13, 97);
			this.lblCorrectGuessesDesc.Name = "lblCorrectGuessesDesc";
			this.lblCorrectGuessesDesc.Padding = new System.Windows.Forms.Padding(5);
			this.lblCorrectGuessesDesc.Size = new System.Drawing.Size(110, 23);
			this.lblCorrectGuessesDesc.TabIndex = 5;
			this.lblCorrectGuessesDesc.Text = "Richtige Antworten:";
			// 
			// lblWrongGuessesDesc
			// 
			this.lblWrongGuessesDesc.AutoSize = true;
			this.lblWrongGuessesDesc.Location = new System.Drawing.Point(13, 120);
			this.lblWrongGuessesDesc.Name = "lblWrongGuessesDesc";
			this.lblWrongGuessesDesc.Padding = new System.Windows.Forms.Padding(5);
			this.lblWrongGuessesDesc.Size = new System.Drawing.Size(108, 23);
			this.lblWrongGuessesDesc.TabIndex = 6;
			this.lblWrongGuessesDesc.Text = "Falsche Antworten:";
			// 
			// lblAmountExercises
			// 
			this.lblAmountExercises.AutoSize = true;
			this.lblAmountExercises.Location = new System.Drawing.Point(129, 74);
			this.lblAmountExercises.Name = "lblAmountExercises";
			this.lblAmountExercises.Padding = new System.Windows.Forms.Padding(5);
			this.lblAmountExercises.Size = new System.Drawing.Size(23, 23);
			this.lblAmountExercises.TabIndex = 7;
			this.lblAmountExercises.Text = "0";
			// 
			// lblAmountCorrect
			// 
			this.lblAmountCorrect.AutoSize = true;
			this.lblAmountCorrect.Location = new System.Drawing.Point(129, 97);
			this.lblAmountCorrect.Name = "lblAmountCorrect";
			this.lblAmountCorrect.Padding = new System.Windows.Forms.Padding(5);
			this.lblAmountCorrect.Size = new System.Drawing.Size(23, 23);
			this.lblAmountCorrect.TabIndex = 7;
			this.lblAmountCorrect.Text = "0";
			// 
			// lblAmountWrong
			// 
			this.lblAmountWrong.AutoSize = true;
			this.lblAmountWrong.Location = new System.Drawing.Point(129, 120);
			this.lblAmountWrong.Name = "lblAmountWrong";
			this.lblAmountWrong.Padding = new System.Windows.Forms.Padding(5);
			this.lblAmountWrong.Size = new System.Drawing.Size(23, 23);
			this.lblAmountWrong.TabIndex = 7;
			this.lblAmountWrong.Text = "0";
			// 
			// lstLastExercises
			// 
			this.lstLastExercises.ColumnWidth = 75;
			this.lstLastExercises.FormattingEnabled = true;
			this.lstLastExercises.Location = new System.Drawing.Point(293, 97);
			this.lstLastExercises.MultiColumn = true;
			this.lstLastExercises.Name = "lstLastExercises";
			this.lstLastExercises.Size = new System.Drawing.Size(244, 290);
			this.lstLastExercises.TabIndex = 8;
			// 
			// lblLastExercisesDesc
			// 
			this.lblLastExercisesDesc.AutoSize = true;
			this.lblLastExercisesDesc.Location = new System.Drawing.Point(290, 74);
			this.lblLastExercisesDesc.Name = "lblLastExercisesDesc";
			this.lblLastExercisesDesc.Padding = new System.Windows.Forms.Padding(5);
			this.lblLastExercisesDesc.Size = new System.Drawing.Size(98, 23);
			this.lblLastExercisesDesc.TabIndex = 4;
			this.lblLastExercisesDesc.Text = "Letzte Aufgaben:";
			// 
			// FrmZahlenraten
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 400);
			this.Controls.Add(this.lstLastExercises);
			this.Controls.Add(this.lblAmountWrong);
			this.Controls.Add(this.lblAmountCorrect);
			this.Controls.Add(this.lblAmountExercises);
			this.Controls.Add(this.lblWrongGuessesDesc);
			this.Controls.Add(this.lblCorrectGuessesDesc);
			this.Controls.Add(this.lblLastExercisesDesc);
			this.Controls.Add(this.lblExercisesDesc);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.lblExercise);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmZahlenraten";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zahlenraten";
			this.Load += new System.EventHandler(this.FrmZahlenraten_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.Label lblExercise;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label lblExercisesDesc;
		private System.Windows.Forms.Label lblCorrectGuessesDesc;
		private System.Windows.Forms.Label lblWrongGuessesDesc;
		private System.Windows.Forms.Label lblAmountExercises;
		private System.Windows.Forms.Label lblAmountCorrect;
		private System.Windows.Forms.Label lblAmountWrong;
		private System.Windows.Forms.ListBox lstLastExercises;
		private System.Windows.Forms.Label lblLastExercisesDesc;
	}
}

