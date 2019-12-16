namespace AwayDay3
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnCancellations = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register New Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Communication";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(240, 174);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(150, 40);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(84, 174);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(150, 40);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.button4);
            this.gbxMain.Controls.Add(this.button3);
            this.gbxMain.Controls.Add(this.btnBilling);
            this.gbxMain.Controls.Add(this.btnCancellations);
            this.gbxMain.Location = new System.Drawing.Point(61, 58);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(354, 224);
            this.gbxMain.TabIndex = 5;
            this.gbxMain.TabStop = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(23, 162);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(150, 40);
            this.btnBilling.TabIndex = 7;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnCancellations
            // 
            this.btnCancellations.Location = new System.Drawing.Point(179, 162);
            this.btnCancellations.Name = "btnCancellations";
            this.btnCancellations.Size = new System.Drawing.Size(150, 40);
            this.btnCancellations.TabIndex = 6;
            this.btnCancellations.Text = "Cancellations";
            this.btnCancellations.UseVisualStyleBackColor = true;
            this.btnCancellations.Click += new System.EventHandler(this.btnCancellations_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Customer sign in";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxMain);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.gbxMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnCancellations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}