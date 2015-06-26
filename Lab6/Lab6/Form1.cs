using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Lab6
{
	/// <summary>
	/// Melissa Pott
	/// CIS275
	/// Lab 6
	/// 
	/// Store the name of a country and related text about the country
	/// in a hashtable.  Search the hashtable for a country name as the
	/// key, and display the related object in a textbox.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox textCountry;
		private System.Windows.Forms.TextBox textInformation;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Hashtable table;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			//Create hashtable
			table = new Hashtable();
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
			this.label2 = new System.Windows.Forms.Label();
			this.textCountry = new System.Windows.Forms.TextBox();
			this.textInformation = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter a country:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Country information:";
			// 
			// textCountry
			// 
			this.textCountry.Location = new System.Drawing.Point(8, 32);
			this.textCountry.Name = "textCountry";
			this.textCountry.TabIndex = 2;
			this.textCountry.Text = "";
			// 
			// textInformation
			// 
			this.textInformation.Location = new System.Drawing.Point(136, 32);
			this.textInformation.Multiline = true;
			this.textInformation.Name = "textInformation";
			this.textInformation.Size = new System.Drawing.Size(184, 200);
			this.textInformation.TabIndex = 3;
			this.textInformation.Text = "";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 280);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(96, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add Information";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(120, 280);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(96, 23);
			this.btnFind.TabIndex = 5;
			this.btnFind.Text = "Find Information";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(232, 280);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 326);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.textInformation);
			this.Controls.Add(this.textCountry);
			this.Controls.Add(this.label2);
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

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			//test to make sure that a name and information have been entered, 
			//then try to add to the hashtable
			if(textCountry.Text != "")
			{
				if(textInformation.Text != "")
				{
					try
					{
						table.Add(textCountry.Text, textInformation.Text);
					}
					catch(ArgumentException argumentException)
					{
						textInformation.Text = argumentException.ToString();
					}
				}
				else
					textInformation.Text = "Please enter country information";
		
			}
			else
				textInformation.Text = "Please enter a country name";
		}
		
		private void btnFind_Click(object sender, System.EventArgs e)
		{
			//look for the country as a key in the hashtable.
			//if it exists, display the related object in the textbox
			object result = table[textCountry.Text];

			if(result!= null)
				textInformation.Text = result.ToString();
			else
				textInformation.Text = "No information to display on " + textCountry.Text;
		}
	}
}
