namespace AwayDay3
{
    partial class Form1
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
            this.lblSignup = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxSignup = new System.Windows.Forms.GroupBox();
            this.status_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(106, 38);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(193, 29);
            this.lblSignup.TabIndex = 2;
            this.lblSignup.Text = "Customer sign in";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(129, 79);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Text = "Company Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(129, 116);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "Department Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(51, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(296, 40);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Sign In";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxSignup
            // 
            this.gbxSignup.Controls.Add(this.status_label);
            this.gbxSignup.Controls.Add(this.btnSubmit);
            this.gbxSignup.Controls.Add(this.lblSignup);
            this.gbxSignup.Controls.Add(this.txtFirstName);
            this.gbxSignup.Controls.Add(this.txtLastName);
            this.gbxSignup.Location = new System.Drawing.Point(69, 33);
            this.gbxSignup.Name = "gbxSignup";
            this.gbxSignup.Size = new System.Drawing.Size(403, 201);
            this.gbxSignup.TabIndex = 76;
            this.gbxSignup.TabStop = false;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(126, 17);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(145, 13);
            this.status_label.TabIndex = 8;
            this.status_label.Text = "Please enter customer details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 40);
            this.button1.TabIndex = 77;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxSignup);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSignup.ResumeLayout(false);
            this.gbxSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxSignup;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button button1;
    }
}

