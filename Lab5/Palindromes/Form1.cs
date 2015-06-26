using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Palindromes
{
	/// <summary>
	/// Melissa Pott
	/// CIS 275
	/// Week 5 Lab
	/// Assignment:  use a stack to test if a word is a palindrome
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textWord;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelOutput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.label1 = new System.Windows.Forms.Label();
			this.textWord = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.labelOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "please enter a word:";
			// 
			// textWord
			// 
			this.textWord.Location = new System.Drawing.Point(120, 16);
			this.textWord.Name = "textWord";
			this.textWord.Size = new System.Drawing.Size(152, 20);
			this.textWord.TabIndex = 1;
			this.textWord.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Detect Palindrome";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelOutput
			// 
			this.labelOutput.Location = new System.Drawing.Point(40, 64);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(232, 48);
			this.labelOutput.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 182);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textWord);
			this.Controls.Add(this.label1);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			string word = textWord.Text;
			Stack stack1 = new Stack();
			string test="";

			//push each character of the word given by the user into a stack
			//this will inherently reverse the order of the word's letters
			for(int i=0; i<word.Length; i++)
			{
				stack1.Push(word[i].ToString());
			}
			
			
			//load the stack back into a string for easy comparison
			for(int i=0; i<word.Length; i++)
			{
				test += stack1.Pop().ToString();	
			}
			
			if(word == test)
				labelOutput.Text = "The word: " + word + " is a palindrome";
			else
				labelOutput.Text = "The word: " + word + " is not a palindrome";

		}


	}
}
