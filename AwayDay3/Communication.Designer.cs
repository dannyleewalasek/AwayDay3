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
            this.lblUpdatedDate = new System.Windows.Forms.Label();
            this.lblAddedDate = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblAddedOn = new System.Windows.Forms.Label();
            this.txtFindClient = new System.Windows.Forms.TextBox();
            this.lblFindClient = new System.Windows.Forms.Label();
            this.btnImportMessage = new System.Windows.Forms.Button();
            this.gbxCommunication = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtCommunication
            // 
            this.txtCommunication.Location = new System.Drawing.Point(116, 136);
            this.txtCommunication.Multiline = true;
            this.txtCommunication.Name = "txtCommunication";
            this.txtCommunication.Size = new System.Drawing.Size(433, 152);
            this.txtCommunication.TabIndex = 25;
            this.txtCommunication.Text = "Day Away Query recieved on 25/03/18 // this will display data pulled form databas" +
    "e";
            // 
            // lblCommunication
            // 
            this.lblCommunication.AutoSize = true;
            this.lblCommunication.Location = new System.Drawing.Point(25, 136);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new System.Drawing.Size(79, 13);
            this.lblCommunication.TabIndex = 24;
            this.lblCommunication.Text = "Communication";
            // 
            // lblUpdatedDate
            // 
            this.lblUpdatedDate.AutoSize = true;
            this.lblUpdatedDate.Location = new System.Drawing.Point(113, 108);
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            this.lblUpdatedDate.Size = new System.Drawing.Size(117, 13);
            this.lblUpdatedDate.TabIndex = 23;
            this.lblUpdatedDate.Text = ": 12 Jun 2014 at: 12:59";
            // 
            // lblAddedDate
            // 
            this.lblAddedDate.AutoSize = true;
            this.lblAddedDate.Location = new System.Drawing.Point(113, 88);
            this.lblAddedDate.Name = "lblAddedDate";
            this.lblAddedDate.Size = new System.Drawing.Size(119, 13);
            this.lblAddedDate.TabIndex = 22;
            this.lblAddedDate.Text = ": 24 Aug 2012 at: 22:39";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(22, 108);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(84, 13);
            this.lblLastUpdated.TabIndex = 21;
            this.lblLastUpdated.Text = "Last updated on";
            // 
            // lblAddedOn
            // 
            this.lblAddedOn.AutoSize = true;
            this.lblAddedOn.Location = new System.Drawing.Point(53, 88);
            this.lblAddedOn.Name = "lblAddedOn";
            this.lblAddedOn.Size = new System.Drawing.Size(53, 13);
            this.lblAddedOn.TabIndex = 20;
            this.lblAddedOn.Text = "Added on";
            // 
            // txtFindClient
            // 
            this.txtFindClient.Location = new System.Drawing.Point(116, 30);
            this.txtFindClient.Name = "txtFindClient";
            this.txtFindClient.Size = new System.Drawing.Size(152, 20);
            this.txtFindClient.TabIndex = 19;
            this.txtFindClient.Text = "Northumbria University";
            // 
            // lblFindClient
            // 
            this.lblFindClient.AutoSize = true;
            this.lblFindClient.Location = new System.Drawing.Point(54, 33);
            this.lblFindClient.Name = "lblFindClient";
            this.lblFindClient.Size = new System.Drawing.Size(56, 13);
            this.lblFindClient.TabIndex = 18;
            this.lblFindClient.Text = "Find Client";
            // 
            // btnImportMessage
            // 
            this.btnImportMessage.Location = new System.Drawing.Point(474, 88);
            this.btnImportMessage.Name = "btnImportMessage";
            this.btnImportMessage.Size = new System.Drawing.Size(75, 42);
            this.btnImportMessage.TabIndex = 16;
            this.btnImportMessage.Text = "Import Messages";
            this.btnImportMessage.UseVisualStyleBackColor = true;
            this.btnImportMessage.Click += new System.EventHandler(this.btnImportMessage_Click);
            // 
            // gbxCommunication
            // 
            this.gbxCommunication.Location = new System.Drawing.Point(12, 7);
            this.gbxCommunication.Name = "gbxCommunication";
            this.gbxCommunication.Size = new System.Drawing.Size(551, 294);
            this.gbxCommunication.TabIndex = 75;
            this.gbxCommunication.TabStop = false;
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 324);
            this.Controls.Add(this.txtCommunication);
            this.Controls.Add(this.lblCommunication);
            this.Controls.Add(this.lblUpdatedDate);
            this.Controls.Add(this.lblAddedDate);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblAddedOn);
            this.Controls.Add(this.txtFindClient);
            this.Controls.Add(this.lblFindClient);
            this.Controls.Add(this.btnImportMessage);
            this.Controls.Add(this.gbxCommunication);
            this.Name = "Communication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommunication;
        private System.Windows.Forms.Label lblCommunication;
        private System.Windows.Forms.Label lblUpdatedDate;
        private System.Windows.Forms.Label lblAddedDate;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblAddedOn;
        private System.Windows.Forms.TextBox txtFindClient;
        private System.Windows.Forms.Label lblFindClient;
        private System.Windows.Forms.Button btnImportMessage;
        private System.Windows.Forms.GroupBox gbxCommunication;
    }
}