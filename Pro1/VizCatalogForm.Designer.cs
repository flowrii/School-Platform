
namespace Pro1
{
    partial class VizCatalogForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(61, 40);
            this.inapoiBtn.TabIndex = 0;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(447, 445);
            this.dataGridView.TabIndex = 1;
            // 
            // notaTextBox
            // 
            this.notaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notaTextBox.Location = new System.Drawing.Point(601, 203);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(52, 29);
            this.notaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(483, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota noua";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(688, 197);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 39);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Actualizeaza";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // VizCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 520);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.inapoiBtn);
            this.Name = "VizCatalogForm";
            this.Text = "VizCatalogForm";
            this.Load += new System.EventHandler(this.VizCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
    }
}