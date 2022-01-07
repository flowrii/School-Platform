
namespace Pro1
{
    partial class DetaliiGrupForm
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
            this.programBtn = new System.Windows.Forms.Button();
            this.mesajeBtn = new System.Windows.Forms.Button();
            this.profBtn = new System.Windows.Forms.Button();
            this.membriiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(79, 42);
            this.inapoiBtn.TabIndex = 0;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // programBtn
            // 
            this.programBtn.Location = new System.Drawing.Point(85, 102);
            this.programBtn.Name = "programBtn";
            this.programBtn.Size = new System.Drawing.Size(229, 58);
            this.programBtn.TabIndex = 1;
            this.programBtn.Text = "Program";
            this.programBtn.UseVisualStyleBackColor = true;
            // 
            // mesajeBtn
            // 
            this.mesajeBtn.Location = new System.Drawing.Point(86, 170);
            this.mesajeBtn.Name = "mesajeBtn";
            this.mesajeBtn.Size = new System.Drawing.Size(229, 58);
            this.mesajeBtn.TabIndex = 2;
            this.mesajeBtn.Text = "Mesaje";
            this.mesajeBtn.UseVisualStyleBackColor = true;
            // 
            // profBtn
            // 
            this.profBtn.Location = new System.Drawing.Point(86, 308);
            this.profBtn.Name = "profBtn";
            this.profBtn.Size = new System.Drawing.Size(229, 58);
            this.profBtn.TabIndex = 4;
            this.profBtn.Text = "Profesor";
            this.profBtn.UseVisualStyleBackColor = true;
            this.profBtn.Click += new System.EventHandler(this.profBtn_Click);
            // 
            // membriiBtn
            // 
            this.membriiBtn.Location = new System.Drawing.Point(85, 240);
            this.membriiBtn.Name = "membriiBtn";
            this.membriiBtn.Size = new System.Drawing.Size(229, 58);
            this.membriiBtn.TabIndex = 3;
            this.membriiBtn.Text = "Membrii";
            this.membriiBtn.UseVisualStyleBackColor = true;
            this.membriiBtn.Click += new System.EventHandler(this.membriiBtn_Click);
            // 
            // DetaliiGrupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 437);
            this.Controls.Add(this.profBtn);
            this.Controls.Add(this.membriiBtn);
            this.Controls.Add(this.mesajeBtn);
            this.Controls.Add(this.programBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Name = "DetaliiGrupForm";
            this.Text = "DetaliiGrupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button programBtn;
        private System.Windows.Forms.Button mesajeBtn;
        private System.Windows.Forms.Button profBtn;
        private System.Windows.Forms.Button membriiBtn;
    }
}