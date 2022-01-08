
namespace Pro1
{
    partial class AdminShowForm
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
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.stergeBtn = new System.Windows.Forms.Button();
            this.asignCursBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cautaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(947, 11);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(110, 29);
            this.adaugaBtn.TabIndex = 1;
            this.adaugaBtn.Text = "Adauga Profesor";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 11);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(110, 29);
            this.inapoiBtn.TabIndex = 2;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // stergeBtn
            // 
            this.stergeBtn.Location = new System.Drawing.Point(831, 12);
            this.stergeBtn.Name = "stergeBtn";
            this.stergeBtn.Size = new System.Drawing.Size(110, 29);
            this.stergeBtn.TabIndex = 3;
            this.stergeBtn.Text = "Sterge";
            this.stergeBtn.UseVisualStyleBackColor = true;
            this.stergeBtn.Click += new System.EventHandler(this.stergeBtn_Click);
            // 
            // asignCursBtn
            // 
            this.asignCursBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asignCursBtn.Location = new System.Drawing.Point(715, 12);
            this.asignCursBtn.Name = "asignCursBtn";
            this.asignCursBtn.Size = new System.Drawing.Size(110, 29);
            this.asignCursBtn.TabIndex = 4;
            this.asignCursBtn.Text = "Asigneaza la curs";
            this.asignCursBtn.UseVisualStyleBackColor = true;
            this.asignCursBtn.Click += new System.EventHandler(this.asignCursBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(786, 534);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 29);
            this.textBox1.TabIndex = 5;
            // 
            // cautaBtn
            // 
            this.cautaBtn.Location = new System.Drawing.Point(967, 534);
            this.cautaBtn.Name = "cautaBtn";
            this.cautaBtn.Size = new System.Drawing.Size(90, 29);
            this.cautaBtn.TabIndex = 6;
            this.cautaBtn.Text = "Cauta";
            this.cautaBtn.UseVisualStyleBackColor = true;
            this.cautaBtn.Click += new System.EventHandler(this.cautaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(635, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cautare avansata:";
            // 
            // AdminShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cautaBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.asignCursBtn);
            this.Controls.Add(this.stergeBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminShowForm";
            this.Text = "AdminShowForm";
            this.Load += new System.EventHandler(this.AdminShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adaugaBtn;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button stergeBtn;
        private System.Windows.Forms.Button asignCursBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cautaBtn;
        private System.Windows.Forms.Label label1;
    }
}