namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.addSomeNewCountriesButton = new System.Windows.Forms.Button();
			this.showAllCountriesButton = new System.Windows.Forms.Button();
			this.countriesListBox = new System.Windows.Forms.ListBox();
			this.countryNameTextBox = new System.Windows.Forms.TextBox();
			this.deleteACountryByNameButton = new System.Windows.Forms.Button();
			this.checkStatesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addSomeNewCountriesButton
			// 
			this.addSomeNewCountriesButton.Location = new System.Drawing.Point(12, 12);
			this.addSomeNewCountriesButton.Name = "addSomeNewCountriesButton";
			this.addSomeNewCountriesButton.Size = new System.Drawing.Size(260, 23);
			this.addSomeNewCountriesButton.TabIndex = 0;
			this.addSomeNewCountriesButton.Text = "Add Some New Countries";
			this.addSomeNewCountriesButton.UseVisualStyleBackColor = true;
			this.addSomeNewCountriesButton.Click += new System.EventHandler(this.AddSomeNewCountriesButton_Click);
			// 
			// showAllCountriesButton
			// 
			this.showAllCountriesButton.Location = new System.Drawing.Point(12, 41);
			this.showAllCountriesButton.Name = "showAllCountriesButton";
			this.showAllCountriesButton.Size = new System.Drawing.Size(260, 23);
			this.showAllCountriesButton.TabIndex = 1;
			this.showAllCountriesButton.Text = "Show All Countries";
			this.showAllCountriesButton.UseVisualStyleBackColor = true;
			this.showAllCountriesButton.Click += new System.EventHandler(this.ShowAllCountriesButton_Click);
			// 
			// countriesListBox
			// 
			this.countriesListBox.FormattingEnabled = true;
			this.countriesListBox.Location = new System.Drawing.Point(12, 70);
			this.countriesListBox.Name = "countriesListBox";
			this.countriesListBox.Size = new System.Drawing.Size(260, 95);
			this.countriesListBox.TabIndex = 2;
			// 
			// countryNameTextBox
			// 
			this.countryNameTextBox.Location = new System.Drawing.Point(12, 171);
			this.countryNameTextBox.Name = "countryNameTextBox";
			this.countryNameTextBox.Size = new System.Drawing.Size(260, 20);
			this.countryNameTextBox.TabIndex = 3;
			// 
			// deleteACountryByNameButton
			// 
			this.deleteACountryByNameButton.Location = new System.Drawing.Point(12, 197);
			this.deleteACountryByNameButton.Name = "deleteACountryByNameButton";
			this.deleteACountryByNameButton.Size = new System.Drawing.Size(260, 23);
			this.deleteACountryByNameButton.TabIndex = 4;
			this.deleteACountryByNameButton.Text = "Delete a Country By Name";
			this.deleteACountryByNameButton.UseVisualStyleBackColor = true;
			this.deleteACountryByNameButton.Click += new System.EventHandler(this.DeleteACountryByNameButton_Click);
			// 
			// checkStatesButton
			// 
			this.checkStatesButton.Location = new System.Drawing.Point(12, 226);
			this.checkStatesButton.Name = "checkStatesButton";
			this.checkStatesButton.Size = new System.Drawing.Size(260, 23);
			this.checkStatesButton.TabIndex = 5;
			this.checkStatesButton.Text = "Check States";
			this.checkStatesButton.UseVisualStyleBackColor = true;
			this.checkStatesButton.Click += new System.EventHandler(this.CheckStatesButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 259);
			this.Controls.Add(this.checkStatesButton);
			this.Controls.Add(this.deleteACountryByNameButton);
			this.Controls.Add(this.countryNameTextBox);
			this.Controls.Add(this.countriesListBox);
			this.Controls.Add(this.showAllCountriesButton);
			this.Controls.Add(this.addSomeNewCountriesButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addSomeNewCountriesButton;
		private System.Windows.Forms.Button showAllCountriesButton;
		private System.Windows.Forms.ListBox countriesListBox;
		private System.Windows.Forms.TextBox countryNameTextBox;
		private System.Windows.Forms.Button deleteACountryByNameButton;
		private System.Windows.Forms.Button checkStatesButton;
	}
}
