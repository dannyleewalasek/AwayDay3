namespace AwayDay3
{
    partial class Communication
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
            this.txtCommunication = new System.Windows.Forms.TextBox();
            this.lblCommunication = new System.Windows.Forms.Label();
            this.btnImportMessage = new System.Windows.Forms.Button();
            this.gbxCommunication = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.company_label = new System.Windows.Forms.Label();
            this.gbxCommunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommunication
            // 
            this.txtCommunication.Location = new System.Drawing.Point(116, 93);
            this.txtCommunication.Multiline = true;
            this.txtCommunication.Name = "txtCommunication";
            this.txtCommunication.Size = new System.Drawing.Size(433, 195);
            this.txtCommunication.TabIndex = 25;
            this.txtCommunication.Text = "Day Away Query recieved on 25/03/18 // this will display data pulled form databas" +
    "e";
            // 
            // lblCommunication
            // 
            this.lblCommunication.AutoSize = true;
            this.lblCommunication.Location = new System.Drawing.Point(19, 89);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new System.Drawing.Size(79, 13);
            this.lblCommunication.TabIndex = 24;
            this.lblCommunication.Text = "Communication";
            // 
            // btnImportMessage
            // 
            this.btnImportMessage.Location = new System.Drawing.Point(-4, 2);
            this.btnImportMessage.Name = "btnImportMessage";
            this.btnImportMessage.Size = new System.Drawing.Size(75, 42);
            this.btnImportMessage.TabIndex = 16;
            this.btnImportMessage.Text = "Home";
            this.btnImportMessage.UseVisualStyleBackColor = true;
            this.btnImportMessage.Click += new System.EventHandler(this.btnImportMessage_Click);
            // 
            // gbxCommunication
            // 
            this.gbxCommunication.Controls.Add(this.company_label);
            this.gbxCommunication.Controls.Add(this.label1);
            this.gbxCommunication.Controls.Add(this.btnImportMessage);
            this.gbxCommunication.Controls.Add(this.lblCommunication);
            this.gbxCommunication.Location = new System.Drawing.Point(12, 7);
            this.gbxCommunication.Name = "gbxCommunication";
            this.gbxCommunication.Size = new System.Drawing.Size(551, 294);
            this.gbxCommunication.TabIndex = 75;
            this.gbxCommunication.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "All communications recorded with ";
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Location = new System.Drawing.Point(267, 47);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(111, 13);
            this.company_label.TabIndex = 26;
            this.company_label.Text = "no company logged in";
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 324);
            this.Controls.Add(this.txtCommunication);
            this.Controls.Add(this.gbxCommunication);
            this.Name = "Communication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communication";
            this.Load += new System.EventHandler(this.Communication_Load);
            this.gbxCommunication.ResumeLayout(false);
            this.gbxCommunication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommunication;
        private System.Windows.Forms.Label lblCommunication;
        private System.Windows.Forms.Button btnImportMessage;
        private System.Windows.Forms.GroupBox gbxCommunication;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label label1;
    }
}