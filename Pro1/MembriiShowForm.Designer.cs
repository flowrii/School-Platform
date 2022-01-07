
namespace Pro1
{
    partial class MembriiShowForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.adaugaProfBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(357, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(83, 46);
            this.inapoiBtn.TabIndex = 1;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // adaugaProfBtn
            // 
            this.adaugaProfBtn.Location = new System.Drawing.Point(283, 12);
            this.adaugaProfBtn.Name = "adaugaProfBtn";
            this.adaugaProfBtn.Size = new System.Drawing.Size(139, 46);
            this.adaugaProfBtn.TabIndex = 2;
            this.adaugaProfBtn.Text = "Adauga Profesor";
            this.adaugaProfBtn.UseVisualStyleBackColor = true;
            // 
            // MembriiShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 488);
            this.Controls.Add(this.adaugaProfBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MembriiShowForm";
            this.Text = "MembriiShowForm";
            this.Load += new System.EventHandler(this.MembriiShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button adaugaProfBtn;
    }
}