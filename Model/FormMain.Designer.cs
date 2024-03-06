namespace StudentManagementBasic
{
	partial class FormMain
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
			this.pan = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// pan
			// 
			this.pan.Location = new System.Drawing.Point(13, 13);
			this.pan.Name = "pan";
			this.pan.Size = new System.Drawing.Size(239, 566);
			this.pan.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(259, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(793, 566);
			this.panel1.TabIndex = 1;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 591);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pan);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pan;
		private System.Windows.Forms.Panel panel1;
	}
}