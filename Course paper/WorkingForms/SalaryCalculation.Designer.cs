﻿namespace Course_paper
{
    partial class SalaryCalculation
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
            this.buttonBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CollapsButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitoringButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.TopPanel.Controls.Add(this.buttonBack);
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
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(25, 25);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<";
            this.buttonBack.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(443, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заработная плата";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.Hours,
            this.Pay,
            this.Bonus,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 428);
            this.dataGridView1.TabIndex = 19;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "ФИО Сотрудника";
            this.fullName.Name = "fullName";
            this.fullName.Width = 258;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Часы за месяц";
            this.Hours.Name = "Hours";
            // 
            // Pay
            // 
            this.Pay.HeaderText = "Ставка";
            this.Pay.Name = "Pay";
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Премия";
            this.Bonus.Name = "Bonus";
            // 
            // total
            // 
            this.total.HeaderText = "Итог";
            this.total.Name = "total";
            // 
            // MonitoringButton
            // 
            this.MonitoringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.MonitoringButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonitoringButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonitoringButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.MonitoringButton.ForeColor = System.Drawing.Color.White;
            this.MonitoringButton.Location = new System.Drawing.Point(774, 352);
            this.MonitoringButton.Name = "MonitoringButton";
            this.MonitoringButton.Size = new System.Drawing.Size(165, 88);
            this.MonitoringButton.TabIndex = 20;
            this.MonitoringButton.Text = "Мониторинг деятельности";
            this.MonitoringButton.UseVisualStyleBackColor = false;
            this.MonitoringButton.Click += new System.EventHandler(this.MonitoringButton_Click);
            // 
            // SalaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.MonitoringButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryCalculation";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CollapsButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label helpButton;
        private System.Windows.Forms.Label buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button MonitoringButton;
    }
}