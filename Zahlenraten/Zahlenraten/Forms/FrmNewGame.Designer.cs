namespace Zahlenraten.Forms
{
	partial class FrmNewGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOkay = new System.Windows.Forms.Button();
			this.nudMinValue = new System.Windows.Forms.NumericUpDown();
			this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkAddition = new System.Windows.Forms.CheckBox();
			this.chkSubtraction = new System.Windows.Forms.CheckBox();
			this.chkMultiplication = new System.Windows.Forms.CheckBox();
			this.chkDivision = new System.Windows.Forms.CheckBox();
			this.chkModulo = new System.Windows.Forms.CheckBox();
			this.chkAllowNegatives = new System.Windows.Forms.CheckBox();
			this.nudAmountExercises = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.grpGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAmountExercises)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(95, 19);
			this.txtUsername.MaxLength = 256;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(200, 22);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.label4);
			this.grpGeneral.Controls.Add(this.chkAllowNegatives);
			this.grpGeneral.Controls.Add(this.label3);
			this.grpGeneral.Controls.Add(this.label2);
			this.grpGeneral.Controls.Add(this.nudMaxValue);
			this.grpGeneral.Controls.Add(this.nudAmountExercises);
			this.grpGeneral.Controls.Add(this.nudMinValue);
			this.grpGeneral.Controls.Add(this.label1);
			this.grpGeneral.Controls.Add(this.txtUsername);
			this.grpGeneral.Location = new System.Drawing.Point(12, 12);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(310, 157);
			this.grpGeneral.TabIndex = 1;
			this.grpGeneral.TabStop = false;
			this.grpGeneral.Text = "Allgemein";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(560, 175);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Abbrechen";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOkay
			// 
			this.btnOkay.Location = new System.Drawing.Point(479, 175);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 3;
			this.btnOkay.Text = "OK";
			this.btnOkay.UseVisualStyleBackColor = true;
			this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
			// 
			// nudMinValue
			// 
			this.nudMinValue.Location = new System.Drawing.Point(95, 47);
			this.nudMinValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudMinValue.Name = "nudMinValue";
			this.nudMinValue.Size = new System.Drawing.Size(72, 20);
			this.nudMinValue.TabIndex = 2;
			// 
			// nudMaxValue
			// 
			this.nudMaxValue.Location = new System.Drawing.Point(95, 73);
			this.nudMaxValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudMaxValue.Name = "nudMaxValue";
			this.nudMaxValue.Size = new System.Drawing.Size(72, 20);
			this.nudMaxValue.TabIndex = 2;
			this.nudMaxValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Min. Operand:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Max. Operand:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkModulo);
			this.groupBox1.Controls.Add(this.chkAddition);
			this.groupBox1.Controls.Add(this.chkSubtraction);
			this.groupBox1.Controls.Add(this.chkDivision);
			this.groupBox1.Controls.Add(this.chkMultiplication);
			this.groupBox1.Location = new System.Drawing.Point(328, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 157);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operanden:";
			// 
			// chkAddition
			// 
			this.chkAddition.AutoSize = true;
			this.chkAddition.Checked = true;
			this.chkAddition.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAddition.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkAddition.Location = new System.Drawing.Point(9, 19);
			this.chkAddition.Name = "chkAddition";
			this.chkAddition.Size = new System.Drawing.Size(138, 19);
			this.chkAddition.TabIndex = 0;
			this.chkAddition.Text = "( + ) - Addition";
			this.chkAddition.UseVisualStyleBackColor = true;
			// 
			// chkSubtraction
			// 
			this.chkSubtraction.AutoSize = true;
			this.chkSubtraction.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSubtraction.Location = new System.Drawing.Point(9, 44);
			this.chkSubtraction.Name = "chkSubtraction";
			this.chkSubtraction.Size = new System.Drawing.Size(159, 19);
			this.chkSubtraction.TabIndex = 0;
			this.chkSubtraction.Text = "( - ) - Subtraktion";
			this.chkSubtraction.UseVisualStyleBackColor = true;
			// 
			// chkMultiplication
			// 
			this.chkMultiplication.AutoSize = true;
			this.chkMultiplication.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkMultiplication.Location = new System.Drawing.Point(9, 69);
			this.chkMultiplication.Name = "chkMultiplication";
			this.chkMultiplication.Size = new System.Drawing.Size(180, 19);
			this.chkMultiplication.TabIndex = 0;
			this.chkMultiplication.Text = "( * ) - Multiplikation";
			this.chkMultiplication.UseVisualStyleBackColor = true;
			// 
			// chkDivision
			// 
			this.chkDivision.AutoSize = true;
			this.chkDivision.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkDivision.Location = new System.Drawing.Point(9, 94);
			this.chkDivision.Name = "chkDivision";
			this.chkDivision.Size = new System.Drawing.Size(138, 19);
			this.chkDivision.TabIndex = 0;
			this.chkDivision.Text = "( / ) - Division";
			this.chkDivision.UseVisualStyleBackColor = true;
			// 
			// chkModulo
			// 
			this.chkModulo.AutoSize = true;
			this.chkModulo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkModulo.Location = new System.Drawing.Point(9, 119);
			this.chkModulo.Name = "chkModulo";
			this.chkModulo.Size = new System.Drawing.Size(124, 19);
			this.chkModulo.TabIndex = 0;
			this.chkModulo.Text = "( % ) - Modulo";
			this.chkModulo.UseVisualStyleBackColor = true;
			// 
			// chkAllowNegatives
			// 
			this.chkAllowNegatives.AutoSize = true;
			this.chkAllowNegatives.Location = new System.Drawing.Point(95, 99);
			this.chkAllowNegatives.Name = "chkAllowNegatives";
			this.chkAllowNegatives.Size = new System.Drawing.Size(168, 17);
			this.chkAllowNegatives.TabIndex = 5;
			this.chkAllowNegatives.Text = "Negative Ergebnisse zulassen";
			this.chkAllowNegatives.UseVisualStyleBackColor = true;
			// 
			// nudAmountExercises
			// 
			this.nudAmountExercises.Location = new System.Drawing.Point(95, 122);
			this.nudAmountExercises.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.nudAmountExercises.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudAmountExercises.Name = "nudAmountExercises";
			this.nudAmountExercises.Size = new System.Drawing.Size(72, 20);
			this.nudAmountExercises.TabIndex = 2;
			this.nudAmountExercises.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Anz. Aufgaben:";
			// 
			// FrmNewGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 205);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.grpGeneral);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmNewGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Neues Spiel";
			this.TopMost = true;
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAmountExercises)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOkay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudMaxValue;
		private System.Windows.Forms.NumericUpDown nudMinValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkModulo;
		private System.Windows.Forms.CheckBox chkAddition;
		private System.Windows.Forms.CheckBox chkSubtraction;
		private System.Windows.Forms.CheckBox chkDivision;
		private System.Windows.Forms.CheckBox chkMultiplication;
		private System.Windows.Forms.CheckBox chkAllowNegatives;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudAmountExercises;
	}
}