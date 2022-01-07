
namespace Pro1
{
    partial class MainFormProfesor
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
            this.contProfBtn = new System.Windows.Forms.Button();
            this.programProfBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.programeazaActBtn = new System.Windows.Forms.Button();
            this.catalogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contProfBtn
            // 
            this.contProfBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contProfBtn.Location = new System.Drawing.Point(84, 93);
            this.contProfBtn.Name = "contProfBtn";
            this.contProfBtn.Size = new System.Drawing.Size(257, 77);
            this.contProfBtn.TabIndex = 0;
            this.contProfBtn.Text = "Detalii cont";
            this.contProfBtn.UseVisualStyleBackColor = true;
            this.contProfBtn.Click += new System.EventHandler(this.contProfBtn_Click);
            // 
            // programProfBtn
            // 
            this.programProfBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programProfBtn.Location = new System.Drawing.Point(84, 176);
            this.programProfBtn.Name = "programProfBtn";
            this.programProfBtn.Size = new System.Drawing.Size(257, 77);
            this.programProfBtn.TabIndex = 1;
            this.programProfBtn.Text = "Program";
            this.programProfBtn.UseVisualStyleBackColor = true;
            this.programProfBtn.Click += new System.EventHandler(this.programProfBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bun venit, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(201, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(313, 475);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 43);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Ieșire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(12, 475);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(106, 43);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Delogare";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // programeazaActBtn
            // 
            this.programeazaActBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programeazaActBtn.Location = new System.Drawing.Point(84, 259);
            this.programeazaActBtn.Name = "programeazaActBtn";
            this.programeazaActBtn.Size = new System.Drawing.Size(257, 77);
            this.programeazaActBtn.TabIndex = 6;
            this.programeazaActBtn.Text = "Programeaza activitate";
            this.programeazaActBtn.UseVisualStyleBackColor = true;
            this.programeazaActBtn.Click += new System.EventHandler(this.programeazaActBtn_Click);
            // 
            // catalogBtn
            // 
            this.catalogBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalogBtn.Location = new System.Drawing.Point(84, 342);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(257, 77);
            this.catalogBtn.TabIndex = 7;
            this.catalogBtn.Text = "Catalog";
            this.catalogBtn.UseVisualStyleBackColor = true;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // MainFormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 530);
            this.Controls.Add(this.catalogBtn);
            this.Controls.Add(this.programeazaActBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programProfBtn);
            this.Controls.Add(this.contProfBtn);
            this.Name = "MainFormProfesor";
            this.Text = "MainFormProfesor";
            this.Load += new System.EventHandler(this.MainFormProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contProfBtn;
        private System.Windows.Forms.Button programProfBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button programeazaActBtn;
        private System.Windows.Forms.Button catalogBtn;
    }
}