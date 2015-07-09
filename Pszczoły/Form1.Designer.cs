namespace Pszczoły
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignjob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęgnacja jaj",
            "Nauczanie pszczółek",
            "Utrzymywanie ula",
            "Patrol z żądłami"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 53);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(218, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(261, 54);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(60, 20);
            this.shifts.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignjob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // assignjob
            // 
            this.assignjob.Location = new System.Drawing.Point(6, 80);
            this.assignjob.Name = "assignjob";
            this.assignjob.Size = new System.Drawing.Size(218, 23);
            this.assignjob.TabIndex = 3;
            this.assignjob.Text = "Przypisz tę pracę pszczole";
            this.assignjob.UseVisualStyleBackColor = true;
            this.assignjob.Click += new System.EventHandler(this.assignjob_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadanie robotnicy";
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(366, 44);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(90, 70);
            this.nextShift.TabIndex = 3;
            this.nextShift.Text = "Przepracuj następną zmianę";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(15, 171);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(440, 119);
            this.report.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 296);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "System zarządzania ulem";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignjob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox report;
    }
}

