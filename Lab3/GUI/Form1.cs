using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace GUI
{
	/// <summary>
	/// Melissa Pott
	/// CIS275
	/// Lab 3
	/// 
	/// A simple GUI calculator
	/// 
	/// Clicking any of the numbered buttons will append that number to 
	/// the end of the text string in the text box.  When the plus button
	/// is clicked, the text string appearing in the text box is converted
	/// to an integer and added to the variable oldValue.  When the equal
	/// button is clicked, the last number entered by the user, if any,
	/// is added to the oldValue variable, and the result is displayed
	/// in the text box.  Clicking the clear button clears the numbers 
	/// entered and resets the text box to empty.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{

		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnEquals;
		private System.Windows.Forms.TextBox textResult;
		private int oldValue = 0;
		private System.Windows.Forms.Button btnOne;
		private System.Windows.Forms.Button btnTwo;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnThree;
		private System.Windows.Forms.Button btnFour;
		private System.Windows.Forms.Button btnFive;
		private System.Windows.Forms.Button btnSix;
		private System.Windows.Forms.Button btnSeven;
		private System.Windows.Forms.Button btnEight;
		private System.Windows.Forms.Button btnNine;
		private System.Windows.Forms.Button btnZero;
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
			this.btnOne = new System.Windows.Forms.Button();
			this.btnTwo = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnEquals = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.textResult = new System.Windows.Forms.TextBox();
			this.btnThree = new System.Windows.Forms.Button();
			this.btnFour = new System.Windows.Forms.Button();
			this.btnFive = new System.Windows.Forms.Button();
			this.btnSix = new System.Windows.Forms.Button();
			this.btnSeven = new System.Windows.Forms.Button();
			this.btnEight = new System.Windows.Forms.Button();
			this.btnNine = new System.Windows.Forms.Button();
			this.btnZero = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOne
			// 
			this.btnOne.BackColor = System.Drawing.SystemColors.Control;
			this.btnOne.Location = new System.Drawing.Point(32, 72);
			this.btnOne.Name = "btnOne";
			this.btnOne.Size = new System.Drawing.Size(50, 50);
			this.btnOne.TabIndex = 0;
			this.btnOne.Text = "1";
			this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
			// 
			// btnTwo
			// 
			this.btnTwo.BackColor = System.Drawing.SystemColors.Control;
			this.btnTwo.Location = new System.Drawing.Point(96, 72);
			this.btnTwo.Name = "btnTwo";
			this.btnTwo.Size = new System.Drawing.Size(50, 50);
			this.btnTwo.TabIndex = 1;
			this.btnTwo.Text = "2";
			this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
			this.btnPlus.ForeColor = System.Drawing.Color.Red;
			this.btnPlus.Location = new System.Drawing.Point(32, 240);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(50, 50);
			this.btnPlus.TabIndex = 2;
			this.btnPlus.Text = "+";
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnEquals
			// 
			this.btnEquals.BackColor = System.Drawing.SystemColors.Control;
			this.btnEquals.Enabled = false;
			this.btnEquals.ForeColor = System.Drawing.Color.Red;
			this.btnEquals.Location = new System.Drawing.Point(160, 240);
			this.btnEquals.Name = "btnEquals";
			this.btnEquals.Size = new System.Drawing.Size(50, 50);
			this.btnEquals.TabIndex = 3;
			this.btnEquals.Text = "=";
			this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.SystemColors.Control;
			this.btnClear.Location = new System.Drawing.Point(88, 304);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// textResult
			// 
			this.textResult.Location = new System.Drawing.Point(32, 32);
			this.textResult.Name = "textResult";
			this.textResult.Size = new System.Drawing.Size(184, 20);
			this.textResult.TabIndex = 5;
			this.textResult.Text = "";
			// 
			// btnThree
			// 
			this.btnThree.BackColor = System.Drawing.SystemColors.Control;
			this.btnThree.Location = new System.Drawing.Point(160, 72);
			this.btnThree.Name = "btnThree";
			this.btnThree.Size = new System.Drawing.Size(50, 50);
			this.btnThree.TabIndex = 6;
			this.btnThree.Text = "3";
			this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
			// 
			// btnFour
			// 
			this.btnFour.BackColor = System.Drawing.SystemColors.Control;
			this.btnFour.Location = new System.Drawing.Point(32, 128);
			this.btnFour.Name = "btnFour";
			this.btnFour.Size = new System.Drawing.Size(50, 50);
			this.btnFour.TabIndex = 7;
			this.btnFour.Text = "4";
			this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
			// 
			// btnFive
			// 
			this.btnFive.BackColor = System.Drawing.SystemColors.Control;
			this.btnFive.Location = new System.Drawing.Point(96, 128);
			this.btnFive.Name = "btnFive";
			this.btnFive.Size = new System.Drawing.Size(50, 50);
			this.btnFive.TabIndex = 8;
			this.btnFive.Text = "5";
			this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
			// 
			// btnSix
			// 
			this.btnSix.BackColor = System.Drawing.SystemColors.Control;
			this.btnSix.Location = new System.Drawing.Point(160, 128);
			this.btnSix.Name = "btnSix";
			this.btnSix.Size = new System.Drawing.Size(50, 50);
			this.btnSix.TabIndex = 9;
			this.btnSix.Text = "6";
			this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
			// 
			// btnSeven
			// 
			this.btnSeven.BackColor = System.Drawing.SystemColors.Control;
			this.btnSeven.Location = new System.Drawing.Point(32, 184);
			this.btnSeven.Name = "btnSeven";
			this.btnSeven.Size = new System.Drawing.Size(50, 50);
			this.btnSeven.TabIndex = 10;
			this.btnSeven.Text = "7";
			this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
			// 
			// btnEight
			// 
			this.btnEight.BackColor = System.Drawing.SystemColors.Control;
			this.btnEight.Location = new System.Drawing.Point(96, 184);
			this.btnEight.Name = "btnEight";
			this.btnEight.Size = new System.Drawing.Size(50, 50);
			this.btnEight.TabIndex = 11;
			this.btnEight.Text = "8";
			this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
			// 
			// btnNine
			// 
			this.btnNine.BackColor = System.Drawing.SystemColors.Control;
			this.btnNine.Location = new System.Drawing.Point(160, 184);
			this.btnNine.Name = "btnNine";
			this.btnNine.Size = new System.Drawing.Size(50, 50);
			this.btnNine.TabIndex = 12;
			this.btnNine.Text = "9";
			this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
			// 
			// btnZero
			// 
			this.btnZero.BackColor = System.Drawing.SystemColors.Control;
			this.btnZero.Location = new System.Drawing.Point(96, 240);
			this.btnZero.Name = "btnZero";
			this.btnZero.Size = new System.Drawing.Size(50, 50);
			this.btnZero.TabIndex = 13;
			this.btnZero.Text = "0";
			this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(256, 350);
			this.Controls.Add(this.btnZero);
			this.Controls.Add(this.btnNine);
			this.Controls.Add(this.btnEight);
			this.Controls.Add(this.btnSeven);
			this.Controls.Add(this.btnSix);
			this.Controls.Add(this.btnFive);
			this.Controls.Add(this.btnFour);
			this.Controls.Add(this.btnThree);
			this.Controls.Add(this.textResult);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnEquals);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnTwo);
			this.Controls.Add(this.btnOne);
			this.Name = "Form1";
			this.Text = "Simple Calculator";
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


		private void btnOne_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "1";
		}

		private void btnTwo_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "2";
		}

		private void btnThree_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "3";
		}

		private void btnFour_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "4";
		}

		private void btnFive_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "5";
		}

		private void btnSix_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "6";
		}

		private void btnSeven_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "7";
		}

		private void btnEight_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "8";
		}

		private void btnNine_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "9";
		}

		private void btnZero_Click(object sender, System.EventArgs e)
		{
			textResult.Text += "0";
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			textResult.Text = "";
		}

		private void btnPlus_Click(object sender, System.EventArgs e)
		{
			if(textResult.Text != "")
			oldValue = oldValue + Convert.ToInt32(textResult.Text);
			textResult.Text = "";
			btnEquals.Enabled = true;
		}

		private void btnEquals_Click(object sender, System.EventArgs e)
		{
			if(textResult.Text != "")
			oldValue = oldValue + Convert.ToInt32(textResult.Text);
			textResult.Text = oldValue.ToString();
			oldValue = 0;
		}
	}
}
