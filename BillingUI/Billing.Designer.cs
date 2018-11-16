namespace Events_POC
{
    partial class Billing
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
            this.lstPayers = new System.Windows.Forms.ListBox();
            this.lstProcessedPayers = new System.Windows.Forms.ListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPayers
            // 
            this.lstPayers.FormattingEnabled = true;
            this.lstPayers.Location = new System.Drawing.Point(52, 45);
            this.lstPayers.Name = "lstPayers";
            this.lstPayers.Size = new System.Drawing.Size(303, 303);
            this.lstPayers.TabIndex = 0;
            // 
            // lstProcessedPayers
            // 
            this.lstProcessedPayers.FormattingEnabled = true;
            this.lstProcessedPayers.Location = new System.Drawing.Point(413, 45);
            this.lstProcessedPayers.Name = "lstProcessedPayers";
            this.lstProcessedPayers.Size = new System.Drawing.Size(310, 303);
            this.lstProcessedPayers.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(52, 374);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(303, 44);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PAYERS";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lstProcessedPayers);
            this.Controls.Add(this.lstPayers);
            this.Name = "Billing";
            this.Text = "Batch Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPayers;
        private System.Windows.Forms.ListBox lstProcessedPayers;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label1;
    }
}

