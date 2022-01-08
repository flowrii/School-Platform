
namespace Pro1
{
    partial class ActivitatiGRUPForm
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
            this.dataGridViewG = new System.Windows.Forms.DataGridView();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newActBtn = new System.Windows.Forms.Button();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.adaugaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewG
            // 
            this.dataGridViewG.AllowUserToAddRows = false;
            this.dataGridViewG.AllowUserToDeleteRows = false;
            this.dataGridViewG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewG.Location = new System.Drawing.Point(55, 125);
            this.dataGridViewG.Name = "dataGridViewG";
            this.dataGridViewG.ReadOnly = true;
            this.dataGridViewG.RowTemplate.Height = 25;
            this.dataGridViewG.Size = new System.Drawing.Size(330, 288);
            this.dataGridViewG.TabIndex = 0;
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.AllowUserToAddRows = false;
            this.dataGridViewS.AllowUserToDeleteRows = false;
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Location = new System.Drawing.Point(549, 125);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.ReadOnly = true;
            this.dataGridViewS.RowTemplate.Height = 25;
            this.dataGridViewS.Size = new System.Drawing.Size(330, 288);
            this.dataGridViewS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activitati la care ma pot inscrie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(651, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activitatile mele";
            // 
            // newActBtn
            // 
            this.newActBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newActBtn.Location = new System.Drawing.Point(433, 245);
            this.newActBtn.Name = "newActBtn";
            this.newActBtn.Size = new System.Drawing.Size(70, 42);
            this.newActBtn.TabIndex = 4;
            this.newActBtn.Text = ">>";
            this.newActBtn.UseVisualStyleBackColor = true;
            this.newActBtn.Click += new System.EventHandler(this.newActBtn_Click);
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(77, 36);
            this.inapoiBtn.TabIndex = 5;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(830, 12);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(108, 36);
            this.adaugaBtn.TabIndex = 6;
            this.adaugaBtn.Text = "Activitate Noua";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // ActivitatiGRUPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.newActBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewS);
            this.Controls.Add(this.dataGridViewG);
            this.Name = "ActivitatiGRUPForm";
            this.Text = "ActivitatiGRUPForm";
            this.Load += new System.EventHandler(this.ActivitatiGRUPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewG;
        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newActBtn;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button adaugaBtn;
    }
}