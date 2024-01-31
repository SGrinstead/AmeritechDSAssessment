namespace AmeritechDSAssessment
{
	partial class AssessmentForm
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
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.SelectedFileNameText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(268, 94);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
			this.SelectFileButton.TabIndex = 0;
			this.SelectFileButton.Text = "Select a File";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// SelectedFileNameText
			// 
			this.SelectedFileNameText.Location = new System.Drawing.Point(268, 147);
			this.SelectedFileNameText.Name = "SelectedFileNameText";
			this.SelectedFileNameText.ReadOnly = true;
			this.SelectedFileNameText.Size = new System.Drawing.Size(100, 20);
			this.SelectedFileNameText.TabIndex = 1;
			// 
			// AssessmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SelectedFileNameText);
			this.Controls.Add(this.SelectFileButton);
			this.Name = "AssessmentForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.TextBox SelectedFileNameText;
	}
}

