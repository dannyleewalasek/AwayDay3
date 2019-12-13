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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnCancellations = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Find Existing Client";
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.btnBilling);
            this.gbxMain.Controls.Add(this.btnCancellations);
            this.gbxMain.Location = new System.Drawing.Point(61, 78);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(354, 204);
            this.gbxMain.TabIndex = 5;
            this.gbxMain.TabStop = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(23, 142);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(150, 40);
            this.btnBilling.TabIndex = 7;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnCancellations
            // 
            this.btnCancellations.Location = new System.Drawing.Point(179, 142);
            this.btnCancellations.Name = "btnCancellations";
            this.btnCancellations.Size = new System.Drawing.Size(150, 40);
            this.btnCancellations.TabIndex = 6;
            this.btnCancellations.Text = "Cancellations";
            this.btnCancellations.UseVisualStyleBackColor = true;
            this.btnCancellations.Click += new System.EventHandler(this.btnCancellations_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.textBox1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnCancellations;
    }
}