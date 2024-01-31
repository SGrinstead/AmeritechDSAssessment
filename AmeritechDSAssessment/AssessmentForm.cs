using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmeritechDSAssessment
{
	public partial class AssessmentForm : Form
	{
        private string FilePath { get; set; }
		private string[] FileLines { get; set; }

		public AssessmentForm()
		{
			InitializeComponent();
			FilePath = string.Empty;
			
		}

		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
			DialogResult result = openFileDialog.ShowDialog();

			if(result == DialogResult.OK)
			{
				FilePath = openFileDialog.FileName;
				SelectedFileNameTextbox.Text = FilePath;
			}
		}

		private void SolveButton_Click(object sender, EventArgs e)
		{
			if(FilePath != string.Empty)
			{
				FileLines = File.ReadAllLines(FilePath);
				foreach(string s in FileLines)
				{
					Debug.WriteLine(s);
				}
			}
		}

	}
}
