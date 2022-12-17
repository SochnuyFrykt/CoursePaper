using System.Windows.Forms;

namespace Course_paper
{
	partial class MainManuForm
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
			this.TopPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CollapsButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.helpButton = new System.Windows.Forms.Label();
			this.InfoAboutObjectsButton = new System.Windows.Forms.Button();
			this.MonitoringButton = new System.Windows.Forms.Button();
			this.SalaryCalcButton = new System.Windows.Forms.Button();
			this.OrdersButton = new System.Windows.Forms.Button();
			this.DocumentGenerationButton = new System.Windows.Forms.Button();
			this.TopPanel.SuspendLayout();
			this.BottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.TopPanel.Controls.Add(this.label2);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(3, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "<";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(443, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Главное меню";
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
			// 
			// BottomPanel
			// 
			this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.BottomPanel.Controls.Add(this.helpButton);
			this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BottomPanel.Location = new System.Drawing.Point(0, 470);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(1000, 30);
			this.BottomPanel.TabIndex = 2;
			// 
			// helpButton
			// 
			this.helpButton.AutoSize = true;
			this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.helpButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.helpButton.Location = new System.Drawing.Point(3, 3);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(72, 20);
			this.helpButton.TabIndex = 0;
			this.helpButton.Text = "Помощь";
			// 
			// InfoAboutObjectsButton
			// 
			this.InfoAboutObjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.InfoAboutObjectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.InfoAboutObjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.InfoAboutObjectsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.InfoAboutObjectsButton.ForeColor = System.Drawing.Color.White;
			this.InfoAboutObjectsButton.Location = new System.Drawing.Point(130, 105);
			this.InfoAboutObjectsButton.Name = "InfoAboutObjectsButton";
			this.InfoAboutObjectsButton.Size = new System.Drawing.Size(130, 60);
			this.InfoAboutObjectsButton.TabIndex = 11;
			this.InfoAboutObjectsButton.Text = "Информация об объектах";
			this.InfoAboutObjectsButton.UseVisualStyleBackColor = false;
			this.InfoAboutObjectsButton.Click += new System.EventHandler(this.InfoAboutObjectsButton_Click);
			// 
			// MonitoringButton
			// 
			this.MonitoringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.MonitoringButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MonitoringButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MonitoringButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.MonitoringButton.ForeColor = System.Drawing.Color.White;
			this.MonitoringButton.Location = new System.Drawing.Point(290, 105);
			this.MonitoringButton.Name = "MonitoringButton";
			this.MonitoringButton.Size = new System.Drawing.Size(130, 60);
			this.MonitoringButton.TabIndex = 12;
			this.MonitoringButton.Text = "Мониторинг деятельности";
			this.MonitoringButton.UseVisualStyleBackColor = false;
			this.MonitoringButton.Click += new System.EventHandler(this.ActivityTrackingButton_Click);
			// 
			// SalaryCalcButton
			// 
			this.SalaryCalcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.SalaryCalcButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SalaryCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SalaryCalcButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.SalaryCalcButton.ForeColor = System.Drawing.Color.White;
			this.SalaryCalcButton.Location = new System.Drawing.Point(450, 105);
			this.SalaryCalcButton.Name = "SalaryCalcButton";
			this.SalaryCalcButton.Size = new System.Drawing.Size(130, 60);
			this.SalaryCalcButton.TabIndex = 13;
			this.SalaryCalcButton.Text = "Расчет заработной платы";
			this.SalaryCalcButton.UseVisualStyleBackColor = false;
			this.SalaryCalcButton.Click += new System.EventHandler(this.SalaryCalcButton_Click);
			// 
			// OrdersButton
			// 
			this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.OrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.OrdersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.OrdersButton.ForeColor = System.Drawing.Color.White;
			this.OrdersButton.Location = new System.Drawing.Point(130, 190);
			this.OrdersButton.Name = "OrdersButton";
			this.OrdersButton.Size = new System.Drawing.Size(130, 60);
			this.OrdersButton.TabIndex = 14;
			this.OrdersButton.Text = "Заказ строительных материалов";
			this.OrdersButton.UseVisualStyleBackColor = false;
			this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
			// 
			// DocumentGenerationButton
			// 
			this.DocumentGenerationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.DocumentGenerationButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DocumentGenerationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DocumentGenerationButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.DocumentGenerationButton.ForeColor = System.Drawing.Color.White;
			this.DocumentGenerationButton.Location = new System.Drawing.Point(290, 190);
			this.DocumentGenerationButton.Name = "DocumentGenerationButton";
			this.DocumentGenerationButton.Size = new System.Drawing.Size(130, 60);
			this.DocumentGenerationButton.TabIndex = 15;
			this.DocumentGenerationButton.Text = "Формирование документов";
			this.DocumentGenerationButton.UseVisualStyleBackColor = false;
			this.DocumentGenerationButton.Click += new System.EventHandler(this.DocumentGenerationButton_Click);
			// 
			// MainManuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(1000, 500);
			this.Controls.Add(this.DocumentGenerationButton);
			this.Controls.Add(this.OrdersButton);
			this.Controls.Add(this.SalaryCalcButton);
			this.Controls.Add(this.MonitoringButton);
			this.Controls.Add(this.InfoAboutObjectsButton);
			this.Controls.Add(this.BottomPanel);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainManuForm";
			this.Text = "MainManuForm";
			this.Load += new System.EventHandler(this.MainManuForm_Load);
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.BottomPanel.ResumeLayout(false);
			this.BottomPanel.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label CollapsButton;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Panel BottomPanel;
		private System.Windows.Forms.Label helpButton;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InfoAboutObjectsButton;
        private System.Windows.Forms.Button SalaryCalcButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button DocumentGenerationButton;
        private System.Windows.Forms.Button MonitoringButton;
    }
}