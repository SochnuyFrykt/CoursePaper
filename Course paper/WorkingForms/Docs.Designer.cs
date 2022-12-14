namespace Course_paper
{
    partial class Docs
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
			this.ButtonBack = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CollapsButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.helpButton = new System.Windows.Forms.Label();
			this.AcceptanceEmployee = new System.Windows.Forms.Button();
			this.DismissalEmployee = new System.Windows.Forms.Button();
			this.ContractCustomer = new System.Windows.Forms.Button();
			this.TopPanel.SuspendLayout();
			this.BottomPanel.SuspendLayout();
			this.SuspendLayout();
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
			this.TopPanel.Size = new System.Drawing.Size(1000, 30);
			this.TopPanel.TabIndex = 1;
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
			this.ButtonBack.TabIndex = 6;
			this.ButtonBack.Text = "<";
			this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(393, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(214, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Формирование документов";
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
			// AcceptanceEmployee
			// 
			this.AcceptanceEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.AcceptanceEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AcceptanceEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AcceptanceEmployee.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.AcceptanceEmployee.ForeColor = System.Drawing.Color.White;
			this.AcceptanceEmployee.Location = new System.Drawing.Point(226, 164);
			this.AcceptanceEmployee.Name = "AcceptanceEmployee";
			this.AcceptanceEmployee.Size = new System.Drawing.Size(165, 88);
			this.AcceptanceEmployee.TabIndex = 13;
			this.AcceptanceEmployee.Text = "Принятие работника";
			this.AcceptanceEmployee.UseVisualStyleBackColor = false;
			this.AcceptanceEmployee.Click += new System.EventHandler(this.AcceptanceEmployee_Click);
			// 
			// DismissalEmployee
			// 
			this.DismissalEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.DismissalEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DismissalEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DismissalEmployee.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.DismissalEmployee.ForeColor = System.Drawing.Color.White;
			this.DismissalEmployee.Location = new System.Drawing.Point(422, 164);
			this.DismissalEmployee.Name = "DismissalEmployee";
			this.DismissalEmployee.Size = new System.Drawing.Size(165, 88);
			this.DismissalEmployee.TabIndex = 14;
			this.DismissalEmployee.Text = "Увольнение работника";
			this.DismissalEmployee.UseVisualStyleBackColor = false;
			this.DismissalEmployee.Click += new System.EventHandler(this.DismissalEmployee_Click);
			// 
			// ContractCustomer
			// 
			this.ContractCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
			this.ContractCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ContractCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ContractCustomer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.ContractCustomer.ForeColor = System.Drawing.Color.White;
			this.ContractCustomer.Location = new System.Drawing.Point(621, 164);
			this.ContractCustomer.Name = "ContractCustomer";
			this.ContractCustomer.Size = new System.Drawing.Size(165, 88);
			this.ContractCustomer.TabIndex = 15;
			this.ContractCustomer.Text = "Оформление контракта с заказчиком";
			this.ContractCustomer.UseVisualStyleBackColor = false;
			this.ContractCustomer.Click += new System.EventHandler(this.ContractCustomer_Click);
			// 
			// Docs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(1000, 500);
			this.Controls.Add(this.ContractCustomer);
			this.Controls.Add(this.DismissalEmployee);
			this.Controls.Add(this.AcceptanceEmployee);
			this.Controls.Add(this.BottomPanel);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Docs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Docs";
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
        private System.Windows.Forms.Label ButtonBack;
        private System.Windows.Forms.Button AcceptanceEmployee;
        private System.Windows.Forms.Button DismissalEmployee;
        private System.Windows.Forms.Button ContractCustomer;
    }
}