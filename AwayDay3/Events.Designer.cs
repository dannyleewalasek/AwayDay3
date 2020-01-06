namespace AwayDay3
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxChoice = new System.Windows.Forms.GroupBox();
            this.gbxEventDetails = new System.Windows.Forms.GroupBox();
            this.numguests = new System.Windows.Forms.NumericUpDown();
            this.box_pricerequest = new System.Windows.Forms.CheckBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_activity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.box_climbing = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.box_gocart = new System.Windows.Forms.CheckBox();
            this.box_meditation = new System.Windows.Forms.CheckBox();
            this.box_teambuilder = new System.Windows.Forms.CheckBox();
            this.box_chocolate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.gbxEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numguests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(7, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 42);
            this.btnSubmit.TabIndex = 70;
            this.btnSubmit.Text = "Home";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(7, 16);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(106, 13);
            this.lblEventName.TabIndex = 37;
            this.lblEventName.Text = "Number of attendees";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 72;
            this.button1.Text = "Submit request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Third Choice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Second Choice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "First Choice";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(436, 132);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 86;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(436, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // gbxChoice
            // 
            this.gbxChoice.Location = new System.Drawing.Point(336, 64);
            this.gbxChoice.Name = "gbxChoice";
            this.gbxChoice.Size = new System.Drawing.Size(318, 107);
            this.gbxChoice.TabIndex = 95;
            this.gbxChoice.TabStop = false;
            // 
            // gbxEventDetails
            // 
            this.gbxEventDetails.Controls.Add(this.numguests);
            this.gbxEventDetails.Controls.Add(this.box_pricerequest);
            this.gbxEventDetails.Controls.Add(this.btn_Add);
            this.gbxEventDetails.Controls.Add(this.txt_activity);
            this.gbxEventDetails.Controls.Add(this.label11);
            this.gbxEventDetails.Controls.Add(this.label10);
            this.gbxEventDetails.Controls.Add(this.box_climbing);
            this.gbxEventDetails.Controls.Add(this.label9);
            this.gbxEventDetails.Controls.Add(this.box_gocart);
            this.gbxEventDetails.Controls.Add(this.box_meditation);
            this.gbxEventDetails.Controls.Add(this.box_teambuilder);
            this.gbxEventDetails.Controls.Add(this.box_chocolate);
            this.gbxEventDetails.Controls.Add(this.label8);
            this.gbxEventDetails.Controls.Add(this.label7);
            this.gbxEventDetails.Controls.Add(this.label3);
            this.gbxEventDetails.Controls.Add(this.label2);
            this.gbxEventDetails.Controls.Add(this.label1);
            this.gbxEventDetails.Controls.Add(this.lblEventName);
            this.gbxEventDetails.Location = new System.Drawing.Point(23, 64);
            this.gbxEventDetails.Name = "gbxEventDetails";
            this.gbxEventDetails.Size = new System.Drawing.Size(307, 404);
            this.gbxEventDetails.TabIndex = 95;
            this.gbxEventDetails.TabStop = false;
            // 
            // numguests
            // 
            this.numguests.Location = new System.Drawing.Point(119, 13);
            this.numguests.Name = "numguests";
            this.numguests.Size = new System.Drawing.Size(88, 20);
            this.numguests.TabIndex = 104;
            // 
            // box_pricerequest
            // 
            this.box_pricerequest.AutoSize = true;
            this.box_pricerequest.Location = new System.Drawing.Point(147, 371);
            this.box_pricerequest.Name = "box_pricerequest";
            this.box_pricerequest.Size = new System.Drawing.Size(15, 14);
            this.box_pricerequest.TabIndex = 103;
            this.box_pricerequest.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(168, 366);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 102;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_activity
            // 
            this.txt_activity.Location = new System.Drawing.Point(9, 365);
            this.txt_activity.Name = "txt_activity";
            this.txt_activity.Size = new System.Drawing.Size(100, 20);
            this.txt_activity.TabIndex = 101;
            this.txt_activity.Text = "Activity name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 78);
            this.label11.TabIndex = 100;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "Other activities";
            // 
            // box_climbing
            // 
            this.box_climbing.AutoSize = true;
            this.box_climbing.Location = new System.Drawing.Point(192, 218);
            this.box_climbing.Name = "box_climbing";
            this.box_climbing.Size = new System.Drawing.Size(15, 14);
            this.box_climbing.TabIndex = 98;
            this.box_climbing.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Wall Climbing experience";
            // 
            // box_gocart
            // 
            this.box_gocart.AutoSize = true;
            this.box_gocart.Location = new System.Drawing.Point(192, 188);
            this.box_gocart.Name = "box_gocart";
            this.box_gocart.Size = new System.Drawing.Size(15, 14);
            this.box_gocart.TabIndex = 96;
            this.box_gocart.UseVisualStyleBackColor = true;
            // 
            // box_meditation
            // 
            this.box_meditation.AutoSize = true;
            this.box_meditation.Location = new System.Drawing.Point(192, 159);
            this.box_meditation.Name = "box_meditation";
            this.box_meditation.Size = new System.Drawing.Size(15, 14);
            this.box_meditation.TabIndex = 45;
            this.box_meditation.UseVisualStyleBackColor = true;
            // 
            // box_teambuilder
            // 
            this.box_teambuilder.AutoSize = true;
            this.box_teambuilder.Location = new System.Drawing.Point(192, 131);
            this.box_teambuilder.Name = "box_teambuilder";
            this.box_teambuilder.Size = new System.Drawing.Size(15, 14);
            this.box_teambuilder.TabIndex = 44;
            this.box_teambuilder.UseVisualStyleBackColor = true;
            // 
            // box_chocolate
            // 
            this.box_chocolate.AutoSize = true;
            this.box_chocolate.Location = new System.Drawing.Point(192, 101);
            this.box_chocolate.Name = "box_chocolate";
            this.box_chocolate.Size = new System.Drawing.Size(15, 14);
            this.box_chocolate.TabIndex = 43;
            this.box_chocolate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Go-cart Experience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Meditation and mindfulness workshop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Team builder outdoor problem solving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Chocolate producing and marketing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Facilitated Events";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(339, 196);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(91, 13);
            this.label_status.TabIndex = 96;
            this.label_status.Text = "Status information";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 479);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxChoice);
            this.Controls.Add(this.gbxEventDetails);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.gbxEventDetails.ResumeLayout(false);
            this.gbxEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numguests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxChoice;
        private System.Windows.Forms.GroupBox gbxEventDetails;
        private System.Windows.Forms.CheckBox box_climbing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox box_gocart;
        private System.Windows.Forms.CheckBox box_meditation;
        private System.Windows.Forms.CheckBox box_teambuilder;
        private System.Windows.Forms.CheckBox box_chocolate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox box_pricerequest;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_activity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.NumericUpDown numguests;
    }
}