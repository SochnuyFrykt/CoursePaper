namespace Course_paper.DocsFolder
{
	partial class ContractCustomer
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
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.helpButton = new System.Windows.Forms.Label();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.ButtonBack = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CollapsButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SNM = new System.Windows.Forms.TextBox();
			this.CustomerOrganization = new System.Windows.Forms.TextBox();
			this.Budget = new System.Windows.Forms.TextBox();
			this.TypeBuilding = new System.Windows.Forms.TextBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.StartDate = new System.Windows.Forms.DateTimePicker();
			this.EndDate = new System.Windows.Forms.DateTimePicker();
			this.BottomPanel.SuspendLayout();
			this.TopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BottomPanel
			// 
			this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.BottomPanel.Controls.Add(this.helpButton);
			this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BottomPanel.Location = new System.Drawing.Point(0, 420);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(650, 30);
			this.BottomPanel.TabIndex = 4;
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
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.TopPanel.Controls.Add(this.ButtonBack);
			this.TopPanel.Controls.Add(this.label3);
			this.TopPanel.Controls.Add(this.CollapsButton);
			this.TopPanel.Controls.Add(this.CloseButton);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(650, 30);
			this.TopPanel.TabIndex = 5;
			this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
			this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
			// 
			// ButtonBack
			// 
			this.ButtonBack.AutoSize = true;
			this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ButtonBack.Location = new System.Drawing.Point(3, 2);
			this.ButtonBack.Name = "ButtonBack";
			this.ButtonBack.Size = new System.Drawing.Size(25, 25);
			this.ButtonBack.TabIndex = 7;
			this.ButtonBack.Text = "<";
			this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(162, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Оформление контракта с заказчиком";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.UseMnemonic = false;
			// 
			// CollapsButton
			// 
			this.CollapsButton.AutoSize = true;
			this.CollapsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CollapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollapsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CollapsButton.Location = new System.Drawing.Point(605, 4);
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
			this.CloseButton.Location = new System.Drawing.Point(628, 6);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(19, 18);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(40, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "ФИО заказчика";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(40, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Организация заказчика";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(40, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Дата начала работ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(40, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(183, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Дата завершения работ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(40, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Бюджет";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(40, 315);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 20);
			this.label7.TabIndex = 11;
			this.label7.Text = "Тип объекта";
			// 
			// SNM
			// 
			this.SNM.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SNM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.SNM.Location = new System.Drawing.Point(245, 82);
			this.SNM.Name = "SNM";
			this.SNM.Size = new System.Drawing.Size(358, 20);
			this.SNM.TabIndex = 12;
			// 
			// CustomerOrganization
			// 
			this.CustomerOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CustomerOrganization.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.CustomerOrganization.Location = new System.Drawing.Point(245, 132);
			this.CustomerOrganization.Name = "CustomerOrganization";
			this.CustomerOrganization.Size = new System.Drawing.Size(358, 20);
			this.CustomerOrganization.TabIndex = 13;
			// 
			// Budget
			// 
			this.Budget.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Budget.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.Budget.Location = new System.Drawing.Point(245, 273);
			this.Budget.Name = "Budget";
			this.Budget.Size = new System.Drawing.Size(358, 20);
			this.Budget.TabIndex = 16;
			// 
			// TypeBuilding
			// 
			this.TypeBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TypeBuilding.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.TypeBuilding.Location = new System.Drawing.Point(245, 315);
			this.TypeBuilding.Name = "TypeBuilding";
			this.TypeBuilding.Size = new System.Drawing.Size(358, 20);
			this.TypeBuilding.TabIndex = 17;
			// 
			// generateButton
			// 
			this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.generateButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.generateButton.ForeColor = System.Drawing.Color.White;
			this.generateButton.Location = new System.Drawing.Point(311, 361);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(230, 26);
			this.generateButton.TabIndex = 18;
			this.generateButton.Text = "Сформировать документ";
			this.generateButton.UseVisualStyleBackColor = false;
			// 
			// StartDate
			// 
			this.StartDate.Location = new System.Drawing.Point(245, 181);
			this.StartDate.Name = "StartDate";
			this.StartDate.Size = new System.Drawing.Size(154, 20);
			this.StartDate.TabIndex = 20;
			// 
			// EndDate
			// 
			this.EndDate.Location = new System.Drawing.Point(245, 225);
			this.EndDate.Name = "EndDate";
			this.EndDate.Size = new System.Drawing.Size(154, 20);
			this.EndDate.TabIndex = 21;
			// 
			// ContractCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(650, 450);
			this.Controls.Add(this.EndDate);
			this.Controls.Add(this.StartDate);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.TypeBuilding);
			this.Controls.Add(this.Budget);
			this.Controls.Add(this.CustomerOrganization);
			this.Controls.Add(this.SNM);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TopPanel);
			this.Controls.Add(this.BottomPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ContractCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ContractDiller";
			this.BottomPanel.ResumeLayout(false);
			this.BottomPanel.PerformLayout();
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel BottomPanel;
		private System.Windows.Forms.Label helpButton;
		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.Label ButtonBack;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label CollapsButton;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox SNM;
		private System.Windows.Forms.TextBox CustomerOrganization;
		private System.Windows.Forms.TextBox Budget;
		private System.Windows.Forms.TextBox TypeBuilding;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.DateTimePicker StartDate;
		private System.Windows.Forms.DateTimePicker EndDate;
	}
}