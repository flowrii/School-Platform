
namespace Pro1
{
    partial class SugestiiForm
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
            this.invitaBtn = new System.Windows.Forms.Button();
            this.inscriereBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(532, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(84, 36);
            this.inapoiBtn.TabIndex = 1;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // invitaBtn
            // 
            this.invitaBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invitaBtn.Location = new System.Drawing.Point(467, 453);
            this.invitaBtn.Name = "invitaBtn";
            this.invitaBtn.Size = new System.Drawing.Size(122, 35);
            this.invitaBtn.TabIndex = 2;
            this.invitaBtn.Text = "Trimite invitatii";
            this.invitaBtn.UseVisualStyleBackColor = true;
            this.invitaBtn.Click += new System.EventHandler(this.invitaBtn_Click);
            // 
            // inscriereBtn
            // 
            this.inscriereBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inscriereBtn.Location = new System.Drawing.Point(208, 441);
            this.inscriereBtn.Name = "inscriereBtn";
            this.inscriereBtn.Size = new System.Drawing.Size(176, 58);
            this.inscriereBtn.TabIndex = 3;
            this.inscriereBtn.Text = "Inscrie-te la activitatea selectata";
            this.inscriereBtn.UseVisualStyleBackColor = true;
            this.inscriereBtn.Click += new System.EventHandler(this.inscriereBtn_Click);
            // 
            // SugestiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 508);
            this.Controls.Add(this.inscriereBtn);
            this.Controls.Add(this.invitaBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SugestiiForm";
            this.Text = "SugestiiForm";
            this.Load += new System.EventHandler(this.SugestiiActivitatiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button invitaBtn;
        private System.Windows.Forms.Button inscriereBtn;
    }
}