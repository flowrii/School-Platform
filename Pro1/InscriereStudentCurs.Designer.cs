
namespace Pro1
{
    partial class InscriereStudentCurs
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
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.selectatiLabel = new System.Windows.Forms.Label();
            this.cursuriComboBox = new System.Windows.Forms.ComboBox();
            this.cursActComboBox = new System.Windows.Forms.ComboBox();
            this.cursLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seminarActComboBox = new System.Windows.Forms.ComboBox();
            this.seminarLabel = new System.Windows.Forms.Label();
            this.labActComboBox = new System.Windows.Forms.ComboBox();
            this.laboratorLabel = new System.Windows.Forms.Label();
            this.inscrieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(62, 34);
            this.inapoiBtn.TabIndex = 0;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // selectatiLabel
            // 
            this.selectatiLabel.AutoSize = true;
            this.selectatiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectatiLabel.Location = new System.Drawing.Point(122, 73);
            this.selectatiLabel.Name = "selectatiLabel";
            this.selectatiLabel.Size = new System.Drawing.Size(117, 21);
            this.selectatiLabel.TabIndex = 1;
            this.selectatiLabel.Text = "Selectati cursul:";
            // 
            // cursuriComboBox
            // 
            this.cursuriComboBox.FormattingEnabled = true;
            this.cursuriComboBox.Location = new System.Drawing.Point(274, 75);
            this.cursuriComboBox.Name = "cursuriComboBox";
            this.cursuriComboBox.Size = new System.Drawing.Size(246, 23);
            this.cursuriComboBox.TabIndex = 2;
            this.cursuriComboBox.SelectedIndexChanged += new System.EventHandler(this.cursuriComboBox_SelectedIndexChanged);
            // 
            // cursActComboBox
            // 
            this.cursActComboBox.FormattingEnabled = true;
            this.cursActComboBox.Location = new System.Drawing.Point(274, 272);
            this.cursActComboBox.Name = "cursActComboBox";
            this.cursActComboBox.Size = new System.Drawing.Size(246, 23);
            this.cursActComboBox.TabIndex = 4;
            // 
            // cursLabel
            // 
            this.cursLabel.AutoSize = true;
            this.cursLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cursLabel.Location = new System.Drawing.Point(122, 270);
            this.cursLabel.Name = "cursLabel";
            this.cursLabel.Size = new System.Drawing.Size(42, 21);
            this.cursLabel.TabIndex = 3;
            this.cursLabel.Text = "Curs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inscrieti-va la activitati specifice cursului ales:";
            // 
            // seminarActComboBox
            // 
            this.seminarActComboBox.FormattingEnabled = true;
            this.seminarActComboBox.Location = new System.Drawing.Point(274, 312);
            this.seminarActComboBox.Name = "seminarActComboBox";
            this.seminarActComboBox.Size = new System.Drawing.Size(246, 23);
            this.seminarActComboBox.TabIndex = 7;
            // 
            // seminarLabel
            // 
            this.seminarLabel.AutoSize = true;
            this.seminarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seminarLabel.Location = new System.Drawing.Point(122, 310);
            this.seminarLabel.Name = "seminarLabel";
            this.seminarLabel.Size = new System.Drawing.Size(68, 21);
            this.seminarLabel.TabIndex = 6;
            this.seminarLabel.Text = "Seminar";
            // 
            // labActComboBox
            // 
            this.labActComboBox.FormattingEnabled = true;
            this.labActComboBox.Location = new System.Drawing.Point(274, 354);
            this.labActComboBox.Name = "labActComboBox";
            this.labActComboBox.Size = new System.Drawing.Size(246, 23);
            this.labActComboBox.TabIndex = 9;
            // 
            // laboratorLabel
            // 
            this.laboratorLabel.AutoSize = true;
            this.laboratorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laboratorLabel.Location = new System.Drawing.Point(122, 352);
            this.laboratorLabel.Name = "laboratorLabel";
            this.laboratorLabel.Size = new System.Drawing.Size(78, 21);
            this.laboratorLabel.TabIndex = 8;
            this.laboratorLabel.Text = "Laborator";
            // 
            // inscrieBtn
            // 
            this.inscrieBtn.Location = new System.Drawing.Point(512, 465);
            this.inscrieBtn.Name = "inscrieBtn";
            this.inscrieBtn.Size = new System.Drawing.Size(106, 37);
            this.inscrieBtn.TabIndex = 10;
            this.inscrieBtn.Text = "Inscriere";
            this.inscrieBtn.UseVisualStyleBackColor = true;
            this.inscrieBtn.Click += new System.EventHandler(this.inscrieBtn_Click);
            // 
            // InscriereStudentCurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 514);
            this.Controls.Add(this.inscrieBtn);
            this.Controls.Add(this.labActComboBox);
            this.Controls.Add(this.laboratorLabel);
            this.Controls.Add(this.seminarActComboBox);
            this.Controls.Add(this.seminarLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cursActComboBox);
            this.Controls.Add(this.cursLabel);
            this.Controls.Add(this.cursuriComboBox);
            this.Controls.Add(this.selectatiLabel);
            this.Controls.Add(this.inapoiBtn);
            this.Name = "InscriereStudentCurs";
            this.Text = "InscriereStudentCurs";
            this.Load += new System.EventHandler(this.InscriereStudentCurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Label selectatiLabel;
        private System.Windows.Forms.ComboBox cursuriComboBox;
        private System.Windows.Forms.ComboBox cursActComboBox;
        private System.Windows.Forms.Label cursLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox seminarActComboBox;
        private System.Windows.Forms.Label seminarLabel;
        private System.Windows.Forms.ComboBox labActComboBox;
        private System.Windows.Forms.Label laboratorLabel;
        private System.Windows.Forms.Button inscrieBtn;
    }
}