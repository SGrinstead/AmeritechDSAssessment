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

		// Opens a File Selector and saves the selected filepath
		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			// Open a file selector, defaults to only show csv files
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
			DialogResult result = openFileDialog.ShowDialog();

			// Save selected FilePath
			if(result == DialogResult.OK)
			{
				FilePath = openFileDialog.FileName;
				// Display selected file name
				SelectedFileNameTextbox.Text = FilePath;
			}
		}

		// Reads previously selected file to an array, converts the values from string to BigInteger, sums the values,
		// and displays the last 10 digits of sum
		private void SolveButton_Click(object sender, EventArgs e)
		{
			ReadFileLines();

			// Cancels method if no file was selected
			if (FileLines is null)
			{
				MessageBox.Show("No file selected");
				return;
			}

			var bigIntList = ConvertToBigIntegersList(FileLines);

			DisplayLastTenDigitsOfSum(bigIntList);
		}

		/// <summary>
		/// Reads file from FilePath Property and saves it in the FileLines Property.
		/// </summary>
		private void ReadFileLines()
		{
			if (FilePath != string.Empty)
			{
				FileLines = File.ReadAllLines(FilePath);
			}
		}

		/// <summary>
		/// Converts a string array into a list of BigIntegers. Uses BigInteger struct from .NET library.
		/// </summary>
		/// <param name="lines"></param>
		/// <returns>A list of BigIntegers.</returns>
		private List<BigInteger> ConvertToBigIntegersList(string[] lines)
		{
			var bigIntList = new List<BigInteger>();

			foreach(string line in lines)
			{
				// parse each line, ignoring single quotes
				var bigInteger = BigInteger.Parse(line.Replace("'", ""));
				bigIntList.Add(bigInteger);
			}

			return bigIntList;
		}

		/// <summary>
		/// Displays the last ten digits of the sum of a List of BigInteger values in a text box.
		/// </summary>
		/// <param name="bigIntegers"></param>
		private void DisplayLastTenDigitsOfSum(List<BigInteger> bigIntegers)
		{
			BigInteger sum = 0;
			foreach(BigInteger bigInteger in bigIntegers) 
			{
				sum += bigInteger;
			}

			// Last 10 digits using modulo operator
			long lastTenDigits = (long)(sum % 10000000000);

			// Display to text box
			ResultTextBox.Text = lastTenDigits.ToString();
		}
	}
}
