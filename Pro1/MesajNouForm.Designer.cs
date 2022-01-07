
namespace Pro1
{
    partial class MesajNouForm
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
            this.mesajTxtBox = new System.Windows.Forms.TextBox();
            this.trimiteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(84, 39);
            this.inapoiBtn.TabIndex = 0;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // mesajTxtBox
            // 
            this.mesajTxtBox.Location = new System.Drawing.Point(44, 81);
            this.mesajTxtBox.Multiline = true;
            this.mesajTxtBox.Name = "mesajTxtBox";
            this.mesajTxtBox.Size = new System.Drawing.Size(397, 134);
            this.mesajTxtBox.TabIndex = 1;
            // 
            // trimiteBtn
            // 
            this.trimiteBtn.Location = new System.Drawing.Point(393, 242);
            this.trimiteBtn.Name = "trimiteBtn";
            this.trimiteBtn.Size = new System.Drawing.Size(97, 38);
            this.trimiteBtn.TabIndex = 2;
            this.trimiteBtn.Text = "Trimite";
            this.trimiteBtn.UseVisualStyleBackColor = true;
            this.trimiteBtn.Click += new System.EventHandler(this.trimiteBtn_Click);
            // 
            // MesajNouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 292);
            this.Controls.Add(this.trimiteBtn);
            this.Controls.Add(this.mesajTxtBox);
            this.Controls.Add(this.inapoiBtn);
            this.Name = "MesajNouForm";
            this.Text = "MesajNouForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.TextBox mesajTxtBox;
        private System.Windows.Forms.Button trimiteBtn;
    }
}