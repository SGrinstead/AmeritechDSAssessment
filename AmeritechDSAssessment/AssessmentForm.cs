using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
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
			var openFileDialog = new OpenFileDialog();
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

			var bigIntList = ConvertToBigIntegersList(FileLines);
			foreach(BigInteger bigInteger in bigIntList)
			{
				Debug.WriteLine(bigInteger);
			}

			DisplayLastTenDigitsOfSum(bigIntList);
		}

		private List<BigInteger> ConvertToBigIntegersList(string[] lines)
		{
			var bigIntList = new List<BigInteger>();

			foreach(string line in lines)
			{
				BigInteger bigInteger = BigInteger.Parse(line.Replace("'", ""));
				bigIntList.Add(bigInteger);
			}

			return bigIntList;
		}

		private void DisplayLastTenDigitsOfSum(List<BigInteger> bigIntegers)
		{
			BigInteger sum = 0;
			foreach(BigInteger bigInteger in bigIntegers) 
			{
				sum += bigInteger;
			}

			long lastTenDigits = (long)(sum % 10000000000);
			ResultTextBox.Text = lastTenDigits.ToString();
		}
	}
}
