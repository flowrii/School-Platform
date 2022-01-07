
namespace Pro1
{
    partial class AdaugaCursForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.numeTxtBox = new System.Windows.Forms.TextBox();
            this.nrMaxTxtBox = new System.Windows.Forms.TextBox();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume curs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar maxim de studenti";
            // 
            // numeTxtBox
            // 
            this.numeTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numeTxtBox.Location = new System.Drawing.Point(277, 66);
            this.numeTxtBox.Name = "numeTxtBox";
            this.numeTxtBox.Size = new System.Drawing.Size(195, 29);
            this.numeTxtBox.TabIndex = 2;
            // 
            // nrMaxTxtBox
            // 
            this.nrMaxTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nrMaxTxtBox.Location = new System.Drawing.Point(277, 114);
            this.nrMaxTxtBox.Name = "nrMaxTxtBox";
            this.nrMaxTxtBox.Size = new System.Drawing.Size(195, 29);
            this.nrMaxTxtBox.TabIndex = 3;
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(71, 29);
            this.inapoiBtn.TabIndex = 4;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(436, 12);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(71, 29);
            this.adaugaBtn.TabIndex = 5;
            this.adaugaBtn.Text = "Adauga";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // AdaugaCursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 181);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.nrMaxTxtBox);
            this.Controls.Add(this.numeTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaCursForm";
            this.Text = "AdaugaCursForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeTxtBox;
        private System.Windows.Forms.TextBox nrMaxTxtBox;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button adaugaBtn;
    }
}