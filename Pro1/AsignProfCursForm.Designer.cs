
namespace Pro1
{
    partial class AsignProfCursForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inregistreazaBtn = new System.Windows.Forms.Button();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curs";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // inregistreazaBtn
            // 
            this.inregistreazaBtn.Location = new System.Drawing.Point(309, 184);
            this.inregistreazaBtn.Name = "inregistreazaBtn";
            this.inregistreazaBtn.Size = new System.Drawing.Size(108, 43);
            this.inregistreazaBtn.TabIndex = 2;
            this.inregistreazaBtn.Text = "Inregistreaza";
            this.inregistreazaBtn.UseVisualStyleBackColor = true;
            this.inregistreazaBtn.Click += new System.EventHandler(this.inregistreazaBtn_Click);
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(16, 10);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(74, 28);
            this.inapoiBtn.TabIndex = 3;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // AsignProfCursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 239);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.inregistreazaBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AsignProfCursForm";
            this.Text = "AsignProfCursForm";
            this.Load += new System.EventHandler(this.AsignProfCursForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button inregistreazaBtn;
        private System.Windows.Forms.Button inapoiBtn;
    }
}