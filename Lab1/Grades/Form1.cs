using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Grades
{
	/// <summary>
	/// Melissa Pott
	/// CIS275
	/// Lab 1
	/// 
	/// Load read only text box with values from a user selected
	/// text file;
	/// Save user entered data from data entry text boxes to user
	/// selected text file.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtDisplay;
		private System.Windows.Forms.Button btnLoad;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtClass;
		private System.Windows.Forms.TextBox txtGrade;
		private StreamReader fileRead;
		private System.Windows.Forms.Button btnSave;
		private StreamWriter fileWrite;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtClass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtGrade = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(72, 192);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.ReadOnly = true;
			this.txtDisplay.Size = new System.Drawing.Size(320, 152);
			this.txtDisplay.TabIndex = 0;
			this.txtDisplay.Text = "";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(128, 144);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Last Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(72, 16);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 3;
			this.txtLastName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "First Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(280, 16);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 5;
			this.txtFirstName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "ID #";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(56, 64);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(48, 20);
			this.txtID.TabIndex = 7;
			this.txtID.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(128, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Class";
			// 
			// txtClass
			// 
			this.txtClass.Location = new System.Drawing.Point(176, 64);
			this.txtClass.Name = "txtClass";
			this.txtClass.TabIndex = 9;
			this.txtClass.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(296, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Grade";
			// 
			// txtGrade
			// 
			this.txtGrade.Location = new System.Drawing.Point(336, 64);
			this.txtGrade.Name = "txtGrade";
			this.txtGrade.TabIndex = 11;
			this.txtGrade.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(264, 144);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 398);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtGrade);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtClass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtDisplay);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			//create an open file dialog and capture the file name selected
			OpenFileDialog fileChooser = new OpenFileDialog();
			string fileName;
			DialogResult result = fileChooser.ShowDialog();
			fileName = fileChooser.FileName;
			
			if (result == DialogResult.Cancel)
				return; //handle the user clicking the dialog cancel button

			fileRead = new StreamReader(fileName); //create an instance of StreamReader
			string textRead;
			txtDisplay.Text = "";

			//read each line in the text file selected and set the 
			//text property of the display text box to the cummulative value
			//of the box plus the next line read
			while (fileRead.Peek() > 0)
			{				
				textRead = fileRead.ReadLine();
				txtDisplay.Text = txtDisplay.Text + "\r\n" + textRead;
			}
			
			fileRead.Close();
			

		}//end btnLoad_Click

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			//create a save file dialog and capture the file name selected
			OpenFileDialog fileChooser = new OpenFileDialog();
			string fileName;
			DialogResult result = fileChooser.ShowDialog();
			fileName = fileChooser.FileName;

			if (result == DialogResult.Cancel)
				return;  //handle the user clicking the dialog cancel button

			fileWrite = new StreamWriter(fileName,true); //create a StreamWriter object
			string textWrite;

			//build the line of text and write it to the file
			textWrite = txtLastName.Text + "," + txtFirstName.Text + "," + txtID.Text
				+ "," + txtClass.Text + "," + txtGrade.Text;

			fileWrite.WriteLine(textWrite);
			
			fileWrite.Close();

		}//end btnSave_Click
	}
}
