
namespace Pro1
{
    partial class AdaugaGrupForm
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
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.numeGrupTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cursuriComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(437, 12);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(71, 29);
            this.adaugaBtn.TabIndex = 11;
            this.adaugaBtn.Text = "Adauga";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(13, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(71, 29);
            this.inapoiBtn.TabIndex = 10;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // numeGrupTxtBox
            // 
            this.numeGrupTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numeGrupTxtBox.Location = new System.Drawing.Point(278, 114);
            this.numeGrupTxtBox.Name = "numeGrupTxtBox";
            this.numeGrupTxtBox.Size = new System.Drawing.Size(195, 29);
            this.numeGrupTxtBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nume grup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Curs";
            // 
            // cursuriComboBox
            // 
            this.cursuriComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cursuriComboBox.FormattingEnabled = true;
            this.cursuriComboBox.Location = new System.Drawing.Point(280, 66);
            this.cursuriComboBox.Name = "cursuriComboBox";
            this.cursuriComboBox.Size = new System.Drawing.Size(193, 29);
            this.cursuriComboBox.TabIndex = 12;
            // 
            // AdaugaGrupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 189);
            this.Controls.Add(this.cursuriComboBox);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.numeGrupTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaGrupForm";
            this.Text = "AdaugaGrupForm";
            this.Load += new System.EventHandler(this.AdaugaGrupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugaBtn;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.TextBox numeGrupTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cursuriComboBox;
    }
}