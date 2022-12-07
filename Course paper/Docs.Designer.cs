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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Docs";
        }

        #endregion
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docs));
            this.label1 = new System.Windows.Forms.Label();
            this.InviteWorkesButton = new System.Windows.Forms.Button();
            this.FireWorkerButton = new System.Windows.Forms.Button();
            this.ContractFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Формирование документов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InviteWorkesButton
            // 
            this.InviteWorkesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.InviteWorkesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InviteWorkesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InviteWorkesButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.InviteWorkesButton.ForeColor = System.Drawing.Color.White;
            this.InviteWorkesButton.Location = new System.Drawing.Point(130, 105);
            this.InviteWorkesButton.Name = "InviteWorkesButton";
            this.InviteWorkesButton.Size = new System.Drawing.Size(130, 60);
            this.InviteWorkesButton.TabIndex = 18;
            this.InviteWorkesButton.Text = "Принятие работника";
            this.InviteWorkesButton.UseVisualStyleBackColor = false;
            // 
            // FireWorkerButton
            // 
            this.FireWorkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.FireWorkerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FireWorkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FireWorkerButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FireWorkerButton.ForeColor = System.Drawing.Color.White;
            this.FireWorkerButton.Location = new System.Drawing.Point(290, 105);
            this.FireWorkerButton.Name = "FireWorkerButton";
            this.FireWorkerButton.Size = new System.Drawing.Size(130, 60);
            this.FireWorkerButton.TabIndex = 19;
            this.FireWorkerButton.Text = "Увольнение работника";
            this.FireWorkerButton.UseVisualStyleBackColor = false;
            // 
            // ContractFormButton
            // 
            this.ContractFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.ContractFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContractFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContractFormButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ContractFormButton.ForeColor = System.Drawing.Color.White;
            this.ContractFormButton.Location = new System.Drawing.Point(450, 105);
            this.ContractFormButton.Name = "ContractFormButton";
            this.ContractFormButton.Size = new System.Drawing.Size(130, 60);
            this.ContractFormButton.TabIndex = 20;
            this.ContractFormButton.Text = "Оформление контракта \r\nс заказчиком";
            this.ContractFormButton.UseVisualStyleBackColor = false;
            // 
            // Docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 415);
            this.Controls.Add(this.ContractFormButton);
            this.Controls.Add(this.FireWorkerButton);
            this.Controls.Add(this.InviteWorkesButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Docs";
            this.Text = "Docs";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.InviteWorkesButton, 0);
            this.Controls.SetChildIndex(this.FireWorkerButton, 0);
            this.Controls.SetChildIndex(this.ContractFormButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InviteWorkesButton;
        private System.Windows.Forms.Button FireWorkerButton;
        private System.Windows.Forms.Button ContractFormButton;
>>>>>>> Development
    }
}