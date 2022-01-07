
namespace Pro1
{
    partial class GrupuriShowForm
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
            this.detaliiBtn = new System.Windows.Forms.Button();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.grupNouBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(379, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(21, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(75, 39);
            this.inapoiBtn.TabIndex = 1;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // detaliiBtn
            // 
            this.detaliiBtn.Location = new System.Drawing.Point(461, 198);
            this.detaliiBtn.Name = "detaliiBtn";
            this.detaliiBtn.Size = new System.Drawing.Size(186, 56);
            this.detaliiBtn.TabIndex = 2;
            this.detaliiBtn.Text = "Detalii Grup";
            this.detaliiBtn.UseVisualStyleBackColor = true;
            this.detaliiBtn.Click += new System.EventHandler(this.detaliiBtn_Click);
            // 
            // leaveBtn
            // 
            this.leaveBtn.Location = new System.Drawing.Point(461, 334);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(186, 56);
            this.leaveBtn.TabIndex = 3;
            this.leaveBtn.Text = "Paraseste Grup";
            this.leaveBtn.UseVisualStyleBackColor = true;
            // 
            // grupNouBtn
            // 
            this.grupNouBtn.Location = new System.Drawing.Point(461, 68);
            this.grupNouBtn.Name = "grupNouBtn";
            this.grupNouBtn.Size = new System.Drawing.Size(186, 56);
            this.grupNouBtn.TabIndex = 4;
            this.grupNouBtn.Text = "Alatura-te unui nou grup";
            this.grupNouBtn.UseVisualStyleBackColor = true;
            this.grupNouBtn.Click += new System.EventHandler(this.grupNouBtn_Click);
            // 
            // GrupuriShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 416);
            this.Controls.Add(this.grupNouBtn);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.detaliiBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GrupuriShowForm";
            this.Text = "GrupuriShowForm";
            this.Load += new System.EventHandler(this.GrupuriShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button detaliiBtn;
        private System.Windows.Forms.Button leaveBtn;
        private System.Windows.Forms.Button grupNouBtn;
    }
}