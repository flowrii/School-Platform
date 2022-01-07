
namespace Pro1
{
    partial class CatalogForm
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
            this.ActComboBox = new System.Windows.Forms.ComboBox();
            this.CursComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.afisareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActComboBox
            // 
            this.ActComboBox.FormattingEnabled = true;
            this.ActComboBox.Items.AddRange(new object[] {
            "Curs",
            "Seminar",
            "Laborator",
            "Colocviu",
            "Examen",
            "Nota Finala"});
            this.ActComboBox.Location = new System.Drawing.Point(232, 78);
            this.ActComboBox.Name = "ActComboBox";
            this.ActComboBox.Size = new System.Drawing.Size(185, 23);
            this.ActComboBox.TabIndex = 10;
            // 
            // CursComboBox
            // 
            this.CursComboBox.FormattingEnabled = true;
            this.CursComboBox.Location = new System.Drawing.Point(232, 49);
            this.CursComboBox.Name = "CursComboBox";
            this.CursComboBox.Size = new System.Drawing.Size(185, 23);
            this.CursComboBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Activitate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Curs";
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inapoiBtn.Location = new System.Drawing.Point(12, 143);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(75, 37);
            this.inapoiBtn.TabIndex = 11;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // afisareBtn
            // 
            this.afisareBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afisareBtn.Location = new System.Drawing.Point(386, 143);
            this.afisareBtn.Name = "afisareBtn";
            this.afisareBtn.Size = new System.Drawing.Size(75, 37);
            this.afisareBtn.TabIndex = 12;
            this.afisareBtn.Text = "Afisare";
            this.afisareBtn.UseVisualStyleBackColor = true;
            this.afisareBtn.Click += new System.EventHandler(this.afisareBtn_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 192);
            this.Controls.Add(this.afisareBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.ActComboBox);
            this.Controls.Add(this.CursComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ActComboBox;
        private System.Windows.Forms.ComboBox CursComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button afisareBtn;
    }
}