namespace hospital_management
{
    partial class EntriesFrm
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
            this.btnPatientEntry = new System.Windows.Forms.Button();
            this.btnDoctorEntry = new System.Windows.Forms.Button();
            this.btnSecretaryEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPatientEntry
            // 
            this.btnPatientEntry.Location = new System.Drawing.Point(81, 116);
            this.btnPatientEntry.Name = "btnPatientEntry";
            this.btnPatientEntry.Size = new System.Drawing.Size(150, 150);
            this.btnPatientEntry.TabIndex = 0;
            this.btnPatientEntry.Text = "Patient Entry";
            this.btnPatientEntry.UseVisualStyleBackColor = true;
            this.btnPatientEntry.Click += new System.EventHandler(this.btnPatientEntry_Click);
            // 
            // btnDoctorEntry
            // 
            this.btnDoctorEntry.Location = new System.Drawing.Point(274, 116);
            this.btnDoctorEntry.Name = "btnDoctorEntry";
            this.btnDoctorEntry.Size = new System.Drawing.Size(150, 150);
            this.btnDoctorEntry.TabIndex = 1;
            this.btnDoctorEntry.Text = "Doctor Entry";
            this.btnDoctorEntry.UseVisualStyleBackColor = true;
            this.btnDoctorEntry.Click += new System.EventHandler(this.btnDoctorEntry_Click);
            // 
            // btnSecretaryEntry
            // 
            this.btnSecretaryEntry.Location = new System.Drawing.Point(465, 116);
            this.btnSecretaryEntry.Name = "btnSecretaryEntry";
            this.btnSecretaryEntry.Size = new System.Drawing.Size(150, 150);
            this.btnSecretaryEntry.TabIndex = 2;
            this.btnSecretaryEntry.Text = "Secretary Entry";
            this.btnSecretaryEntry.UseVisualStyleBackColor = true;
            this.btnSecretaryEntry.Click += new System.EventHandler(this.btnSecretaryEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Choose Entry";
            // 
            // EntriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecretaryEntry);
            this.Controls.Add(this.btnDoctorEntry);
            this.Controls.Add(this.btnPatientEntry);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "EntriesFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientEntry;
        private System.Windows.Forms.Button btnDoctorEntry;
        private System.Windows.Forms.Button btnSecretaryEntry;
        private System.Windows.Forms.Label label1;
    }
}

