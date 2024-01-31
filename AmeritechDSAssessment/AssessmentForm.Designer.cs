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
			this.SelectedFileNameTextbox = new System.Windows.Forms.TextBox();
			this.SolveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(35, 43);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
			this.SelectFileButton.TabIndex = 0;
			this.SelectFileButton.Text = "Select a File";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// SelectedFileNameTextbox
			// 
			this.SelectedFileNameTextbox.Location = new System.Drawing.Point(35, 72);
			this.SelectedFileNameTextbox.Name = "SelectedFileNameTextbox";
			this.SelectedFileNameTextbox.ReadOnly = true;
			this.SelectedFileNameTextbox.Size = new System.Drawing.Size(607, 20);
			this.SelectedFileNameTextbox.TabIndex = 1;
			// 
			// SolveButton
			// 
			this.SolveButton.Location = new System.Drawing.Point(35, 207);
			this.SolveButton.Name = "SolveButton";
			this.SolveButton.Size = new System.Drawing.Size(75, 23);
			this.SolveButton.TabIndex = 2;
			this.SolveButton.Text = "Solve";
			this.SolveButton.UseVisualStyleBackColor = true;
			this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
			// 
			// AssessmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SolveButton);
			this.Controls.Add(this.SelectedFileNameTextbox);
			this.Controls.Add(this.SelectFileButton);
			this.Name = "AssessmentForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.TextBox SelectedFileNameTextbox;
		private System.Windows.Forms.Button SolveButton;
	}
}

