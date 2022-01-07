
namespace Pro1
{
    partial class MainFormStudent
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
            this.detaliiContBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.inscriereBtn = new System.Windows.Forms.Button();
            this.vizualizareNoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detaliiContBtn
            // 
            this.detaliiContBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detaliiContBtn.Location = new System.Drawing.Point(80, 90);
            this.detaliiContBtn.Name = "detaliiContBtn";
            this.detaliiContBtn.Size = new System.Drawing.Size(255, 74);
            this.detaliiContBtn.TabIndex = 0;
            this.detaliiContBtn.Text = "Detalii Cont";
            this.detaliiContBtn.UseVisualStyleBackColor = true;
            this.detaliiContBtn.Click += new System.EventHandler(this.detaliiContBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bun venit, ";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(6, 476);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(106, 43);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "Delogare";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(307, 476);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 43);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Ieșire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // inscriereBtn
            // 
            this.inscriereBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inscriereBtn.Location = new System.Drawing.Point(83, 188);
            this.inscriereBtn.Name = "inscriereBtn";
            this.inscriereBtn.Size = new System.Drawing.Size(255, 74);
            this.inscriereBtn.TabIndex = 8;
            this.inscriereBtn.Text = "Inscriere la curs";
            this.inscriereBtn.UseVisualStyleBackColor = true;
            this.inscriereBtn.Click += new System.EventHandler(this.inscriereBtn_Click);
            // 
            // vizualizareNoteBtn
            // 
            this.vizualizareNoteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vizualizareNoteBtn.Location = new System.Drawing.Point(83, 283);
            this.vizualizareNoteBtn.Name = "vizualizareNoteBtn";
            this.vizualizareNoteBtn.Size = new System.Drawing.Size(255, 74);
            this.vizualizareNoteBtn.TabIndex = 9;
            this.vizualizareNoteBtn.Text = "Vizualizare note";
            this.vizualizareNoteBtn.UseVisualStyleBackColor = true;
            this.vizualizareNoteBtn.Click += new System.EventHandler(this.vizualizareNoteBtn_Click);
            // 
            // MainFormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 531);
            this.Controls.Add(this.vizualizareNoteBtn);
            this.Controls.Add(this.inscriereBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detaliiContBtn);
            this.Name = "MainFormStudent";
            this.Text = "MainFromStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button detaliiContBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button inscriereBtn;
        private System.Windows.Forms.Button vizualizareNoteBtn;
    }
}