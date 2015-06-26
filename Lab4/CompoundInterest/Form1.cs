using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CompoundInterest
{
	/// <summary>
	/// Compound Interest Calculator
	/// Melissa Pott
	/// CIS275
	/// Week 4 Lab
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox investmentAmount;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.ComboBox investmentLength;
		private System.Windows.Forms.ComboBox returnRate;
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

			//fill combo boxes
			for (int i = 1; i<31; i++)
			{
				investmentLength.Items.Add(i);
				returnRate.Items.Add(0.01*i);
			}

			investmentLength.Text = investmentLength.Items[0].ToString();
			returnRate.Text = returnRate.Items[0].ToString();

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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.investmentAmount = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.investmentLength = new System.Windows.Forms.ComboBox();
			this.returnRate = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Yearly Investment Amount";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "How Long (in years)?";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(296, 16);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Return Rate";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(136, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "To Be a Millionaire";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCalculate.Location = new System.Drawing.Point(144, 232);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(144, 23);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "Do You Want?";
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// investmentAmount
			// 
			this.investmentAmount.Location = new System.Drawing.Point(16, 48);
			this.investmentAmount.Name = "investmentAmount";
			this.investmentAmount.TabIndex = 5;
			this.investmentAmount.Text = "";
			// 
			// lblOutput
			// 
			this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(64, 152);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(312, 40);
			this.lblOutput.TabIndex = 6;
			// 
			// investmentLength
			// 
			this.investmentLength.Location = new System.Drawing.Point(144, 48);
			this.investmentLength.Name = "investmentLength";
			this.investmentLength.Size = new System.Drawing.Size(121, 21);
			this.investmentLength.TabIndex = 7;
			this.investmentLength.Text = "comboBox1";
			// 
			// returnRate
			// 
			this.returnRate.Location = new System.Drawing.Point(296, 48);
			this.returnRate.Name = "returnRate";
			this.returnRate.Size = new System.Drawing.Size(121, 21);
			this.returnRate.TabIndex = 8;
			this.returnRate.Text = "comboBox2";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 326);
			this.Controls.Add(this.returnRate);
			this.Controls.Add(this.investmentLength);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.investmentAmount);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
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

		private void btnCalculate_Click(object sender, System.EventArgs e)
		{
			double investResult;

			try //get values entered by user and send them to Calc method
			{
				investResult = Calc(double.Parse(investmentAmount.Text.ToString()),
					int.Parse(investmentLength.SelectedItem.ToString()),
					double.Parse(returnRate.SelectedItem.ToString()));
				lblOutput.Text = investResult.ToString();
			}

			catch
			{
				lblOutput.Text = "Error detected.  Please try again.";
			}

		}

		/// <summary>
		/// Calculate the result of the investment
		/// </summary>
		/// <param name="amount">Amount Invested</param>
		/// <param name="years">Length of investment</param>
		/// <param name="rate">Return Rate</param>
		
		private double Calc(double amount, int years, double rate)
		{
			double result;

			if (years == 1)//1 year is simplest case
			{
				result = amount * (1 + rate);
			}

			else
			{
				result = Calc(amount, years - 1, rate) + amount * Math.Pow(1+rate, years);
			}

			return result;
		}


	}
}
