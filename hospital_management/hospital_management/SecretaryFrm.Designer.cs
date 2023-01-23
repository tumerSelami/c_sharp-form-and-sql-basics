namespace hospital_management
{
    partial class SecretaryFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateAnno = new System.Windows.Forms.Button();
            this.rchAnno = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioStatus = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.mskIDNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAnnos = new System.Windows.Forms.Button();
            this.btnAppoints = new System.Windows.Forms.Button();
            this.btnMajPan = new System.Windows.Forms.Button();
            this.btnDocPan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNameLast);
            this.groupBox1.Controls.Add(this.lblIDNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Information";
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(187, 106);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(76, 23);
            this.lblNameLast.TabIndex = 3;
            this.lblNameLast.Text = "Null Null";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(187, 68);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(131, 23);
            this.lblIDNumber.TabIndex = 2;
            this.lblIDNumber.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name and Last:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateAnno);
            this.groupBox2.Controls.Add(this.rchAnno);
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 245);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcements";
            // 
            // btnCreateAnno
            // 
            this.btnCreateAnno.Location = new System.Drawing.Point(6, 198);
            this.btnCreateAnno.Name = "btnCreateAnno";
            this.btnCreateAnno.Size = new System.Drawing.Size(341, 31);
            this.btnCreateAnno.TabIndex = 1;
            this.btnCreateAnno.Text = "Create";
            this.btnCreateAnno.UseVisualStyleBackColor = true;
            this.btnCreateAnno.Click += new System.EventHandler(this.btnCreateAnno_Click);
            // 
            // rchAnno
            // 
            this.rchAnno.Location = new System.Drawing.Point(6, 30);
            this.rchAnno.Name = "rchAnno";
            this.rchAnno.Size = new System.Drawing.Size(342, 162);
            this.rchAnno.TabIndex = 0;
            this.rchAnno.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.radioStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.mskDate);
            this.groupBox3.Controls.Add(this.mskIDNumber);
            this.groupBox3.Controls.Add(this.mskHour);
            this.groupBox3.Controls.Add(this.cmbMajor);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Location = new System.Drawing.Point(373, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 419);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appoinment Panel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioStatus
            // 
            this.radioStatus.AutoSize = true;
            this.radioStatus.Location = new System.Drawing.Point(121, 291);
            this.radioStatus.Name = "radioStatus";
            this.radioStatus.Size = new System.Drawing.Size(78, 27);
            this.radioStatus.TabIndex = 12;
            this.radioStatus.TabStop = true;
            this.radioStatus.Text = "Status";
            this.radioStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Major:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 31);
            this.txtID.TabIndex = 5;
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(121, 105);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(158, 31);
            this.mskDate.TabIndex = 4;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskIDNumber
            // 
            this.mskIDNumber.Location = new System.Drawing.Point(121, 179);
            this.mskIDNumber.Mask = "00000000000";
            this.mskIDNumber.Name = "mskIDNumber";
            this.mskIDNumber.Size = new System.Drawing.Size(158, 31);
            this.mskIDNumber.TabIndex = 3;
            this.mskIDNumber.ValidatingType = typeof(int);
            // 
            // mskHour
            // 
            this.mskHour.Location = new System.Drawing.Point(121, 142);
            this.mskHour.Mask = "90:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(158, 31);
            this.mskHour.TabIndex = 2;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(121, 216);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(158, 31);
            this.cmbMajor.TabIndex = 1;
            this.cmbMajor.SelectedIndexChanged += new System.EventHandler(this.cmbMajor_SelectedIndexChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(121, 253);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(158, 31);
            this.cmbDoctor.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(726, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 271);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Majors";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(726, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 256);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(475, 226);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAnnos);
            this.groupBox6.Controls.Add(this.btnAppoints);
            this.groupBox6.Controls.Add(this.btnMajPan);
            this.groupBox6.Controls.Add(this.btnDocPan);
            this.groupBox6.Location = new System.Drawing.Point(12, 437);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(708, 114);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btnAnnos
            // 
            this.btnAnnos.Location = new System.Drawing.Point(519, 50);
            this.btnAnnos.Name = "btnAnnos";
            this.btnAnnos.Size = new System.Drawing.Size(160, 34);
            this.btnAnnos.TabIndex = 3;
            this.btnAnnos.Text = "Announcments";
            this.btnAnnos.UseVisualStyleBackColor = true;
            this.btnAnnos.Click += new System.EventHandler(this.btnAnnos_Click);
            // 
            // btnAppoints
            // 
            this.btnAppoints.Location = new System.Drawing.Point(353, 50);
            this.btnAppoints.Name = "btnAppoints";
            this.btnAppoints.Size = new System.Drawing.Size(160, 34);
            this.btnAppoints.TabIndex = 2;
            this.btnAppoints.Text = "Appointment List";
            this.btnAppoints.UseVisualStyleBackColor = true;
            this.btnAppoints.Click += new System.EventHandler(this.btnAppoints_Click);
            // 
            // btnMajPan
            // 
            this.btnMajPan.Location = new System.Drawing.Point(187, 50);
            this.btnMajPan.Name = "btnMajPan";
            this.btnMajPan.Size = new System.Drawing.Size(160, 34);
            this.btnMajPan.TabIndex = 1;
            this.btnMajPan.Text = "Major Panel";
            this.btnMajPan.UseVisualStyleBackColor = true;
            this.btnMajPan.Click += new System.EventHandler(this.btnMajPan_Click);
            // 
            // btnDocPan
            // 
            this.btnDocPan.Location = new System.Drawing.Point(21, 50);
            this.btnDocPan.Name = "btnDocPan";
            this.btnDocPan.Size = new System.Drawing.Size(160, 34);
            this.btnDocPan.TabIndex = 0;
            this.btnDocPan.Text = "Doctor Panel";
            this.btnDocPan.UseVisualStyleBackColor = true;
            this.btnDocPan.Click += new System.EventHandler(this.btnDocPan_Click);
            // 
            // SecretaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1219, 563);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SecretaryFrm";
            this.Text = "SecretaryFrm";
            this.Load += new System.EventHandler(this.SecretaryFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchAnno;
        private System.Windows.Forms.Button btnCreateAnno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.MaskedTextBox mskIDNumber;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAppoints;
        private System.Windows.Forms.Button btnMajPan;
        private System.Windows.Forms.Button btnDocPan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAnnos;
    }
}