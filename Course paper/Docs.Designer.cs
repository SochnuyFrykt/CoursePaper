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
            this.MonitoringButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(443, 5);
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
            // MonitoringButton
            // 
            this.MonitoringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.MonitoringButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonitoringButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonitoringButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.MonitoringButton.ForeColor = System.Drawing.Color.White;
            this.MonitoringButton.Location = new System.Drawing.Point(226, 164);
            this.MonitoringButton.Name = "MonitoringButton";
            this.MonitoringButton.Size = new System.Drawing.Size(165, 88);
            this.MonitoringButton.TabIndex = 13;
            this.MonitoringButton.Text = "Мониторинг деятельности";
            this.MonitoringButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(422, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 88);
            this.button1.TabIndex = 14;
            this.button1.Text = "Мониторинг деятельности";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(621, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 88);
            this.button2.TabIndex = 15;
            this.button2.Text = "Мониторинг деятельности";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MonitoringButton);
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
        private System.Windows.Forms.Button MonitoringButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}