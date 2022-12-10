namespace Course_paper
{
	partial class Template
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
			this.CollapsButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ButtonBack = new System.Windows.Forms.PictureBox();
			this.helpButton = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CollapsButton
			// 
			this.CollapsButton.AutoSize = true;
			this.CollapsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CollapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollapsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CollapsButton.Location = new System.Drawing.Point(680, 4);
			this.CollapsButton.Name = "CollapsButton";
			this.CollapsButton.Size = new System.Drawing.Size(17, 18);
			this.CollapsButton.TabIndex = 1;
			this.CollapsButton.Text = "_";
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CloseButton.Location = new System.Drawing.Point(703, 6);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(19, 18);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.panel2.Controls.Add(this.ButtonBack);
			this.panel2.Controls.Add(this.CollapsButton);
			this.panel2.Controls.Add(this.CloseButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 31);
			this.panel2.TabIndex = 3;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			// 
			// ButtonBack
			// 
			this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonBack.Location = new System.Drawing.Point(5, 3);
			this.ButtonBack.Name = "ButtonBack";
			this.ButtonBack.Size = new System.Drawing.Size(30, 25);
			this.ButtonBack.TabIndex = 11;
			this.ButtonBack.TabStop = false;
			this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// helpButton
			// 
			this.helpButton.AutoSize = true;
			this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.helpButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.helpButton.ForeColor = System.Drawing.Color.White;
			this.helpButton.Location = new System.Drawing.Point(20, 7);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(67, 16);
			this.helpButton.TabIndex = 0;
			this.helpButton.Text = "Помощь";
			this.helpButton.Click += new System.EventHandler(this.ButtonHelp_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.helpButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 384);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 31);
			this.panel1.TabIndex = 10;
			// 
			// Template
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(725, 415);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Template";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Template";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label CollapsButton;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label helpButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox ButtonBack;
	}
}