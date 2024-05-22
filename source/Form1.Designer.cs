namespace CombinedApp
{
    partial class Form1
    {
        private System.Windows.Forms.DateTimePicker PickDate;
        private System.Windows.Forms.Button SendReminder;
        private System.Windows.Forms.PictureBox pictureBox1;

        private void InitializeComponent()
        {
            this.PickDate = new System.Windows.Forms.DateTimePicker();
            this.SendReminder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PickDate
            // 
            this.PickDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.PickDate.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickDate.Location = new System.Drawing.Point(18, 380);
            this.PickDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PickDate.Name = "PickDate";
            this.PickDate.ShowUpDown = true;
            this.PickDate.Size = new System.Drawing.Size(317, 41);
            this.PickDate.TabIndex = 0;
            // 
            // SendReminder
            // 
            this.SendReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendReminder.Location = new System.Drawing.Point(644, 363);
            this.SendReminder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendReminder.Name = "SendReminder";
            this.SendReminder.Size = new System.Drawing.Size(265, 72);
            this.SendReminder.TabIndex = 1;
            this.SendReminder.Text = "Send Reminder";
            this.SendReminder.UseVisualStyleBackColor = true;
            this.SendReminder.Click += new System.EventHandler(this.SendReminder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.BackgroundImage = global::WinFormsApp3.Properties.Resources.clean_medical_background_53876_116875;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(949, 458);
            this.Controls.Add(this.SendReminder);
            this.Controls.Add(this.PickDate);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Combined App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
