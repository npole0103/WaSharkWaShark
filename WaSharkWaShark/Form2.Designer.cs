namespace WaSharkWaShark
{
    partial class Form2
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(23, 50);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(733, 458);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(24, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(36, 12);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "NULL";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save as Json";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(634, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 551);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtLog);
            this.Name = "Form2";
            this.Text = "Packet Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}