namespace Course_paper
{
    partial class Help
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
			this.TopPanel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.CollapsButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.TopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.TopPanel.Controls.Add(this.label3);
			this.TopPanel.Controls.Add(this.CollapsButton);
			this.TopPanel.Controls.Add(this.CloseButton);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(1000, 30);
			this.TopPanel.TabIndex = 1;
			this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
			this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(443, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Помощь";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.UseMnemonic = false;
			// 
			// CollapsButton
			// 
			this.CollapsButton.AutoSize = true;
			this.CollapsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CollapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollapsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CollapsButton.Location = new System.Drawing.Point(955, 4);
			this.CollapsButton.Name = "CollapsButton";
			this.CollapsButton.Size = new System.Drawing.Size(17, 18);
			this.CollapsButton.TabIndex = 1;
			this.CollapsButton.Text = "_";
			this.CollapsButton.Click += new System.EventHandler(this.CollapsButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CloseButton.Location = new System.Drawing.Point(978, 6);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(19, 18);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// BottomPanel
			// 
			this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BottomPanel.Location = new System.Drawing.Point(0, 470);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(1000, 30);
			this.BottomPanel.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.Location = new System.Drawing.Point(12, 36);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(976, 428);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// Help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(1000, 500);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.BottomPanel);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Help";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Help";
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CollapsButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox textBox1;
    }
}