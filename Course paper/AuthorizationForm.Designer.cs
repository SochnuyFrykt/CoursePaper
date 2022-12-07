namespace Course_paper
{
	partial class AuthorizationForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.TopPanel = new System.Windows.Forms.Panel();
			this.CloseButton = new System.Windows.Forms.Label();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.CollapsButton = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TopPanel.SuspendLayout();
			this.BottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.TopPanel.Controls.Add(this.CollapsButton);
			this.TopPanel.Controls.Add(this.CloseButton);
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(350, 30);
			this.TopPanel.TabIndex = 0;
			this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
			this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CloseButton.Location = new System.Drawing.Point(326, 6);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(19, 18);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			// 
			// BottomPanel
			// 
			this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.BottomPanel.Controls.Add(this.label1);
			this.BottomPanel.Location = new System.Drawing.Point(0, 418);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(350, 30);
			this.BottomPanel.TabIndex = 1;
			// 
			// CollapsButton
			// 
			this.CollapsButton.AutoSize = true;
			this.CollapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollapsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CollapsButton.Location = new System.Drawing.Point(301, 4);
			this.CollapsButton.Name = "CollapsButton";
			this.CollapsButton.Size = new System.Drawing.Size(17, 18);
			this.CollapsButton.TabIndex = 1;
			this.CollapsButton.Text = "_";
			this.CollapsButton.Click += new System.EventHandler(this.CollapsButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Помощь";
			// 
			// AuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(350, 450);
			this.Controls.Add(this.BottomPanel);
			this.Controls.Add(this.TopPanel);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AuthorizationForm";
			this.Text = "Form1";
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.BottomPanel.ResumeLayout(false);
			this.BottomPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.Panel BottomPanel;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Label CollapsButton;
		private System.Windows.Forms.Label label1;
	}
}

