
namespace Pro1
{
    partial class ActivitateNouaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.profiComboBox = new System.Windows.Forms.ComboBox();
            this.descriereTxtBox = new System.Windows.Forms.TextBox();
            this.nrMinTxtBox = new System.Windows.Forms.TextBox();
            this.timpExpirareTxtBox = new System.Windows.Forms.TextBox();
            this.oraComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descriere activitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar minim de participanti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timp de inscriere (ore)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(88, 259);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(228, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Doresc sa adaug un profesor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // profiComboBox
            // 
            this.profiComboBox.FormattingEnabled = true;
            this.profiComboBox.Location = new System.Drawing.Point(363, 262);
            this.profiComboBox.Name = "profiComboBox";
            this.profiComboBox.Size = new System.Drawing.Size(189, 23);
            this.profiComboBox.TabIndex = 7;
            // 
            // descriereTxtBox
            // 
            this.descriereTxtBox.Location = new System.Drawing.Point(363, 96);
            this.descriereTxtBox.Name = "descriereTxtBox";
            this.descriereTxtBox.Size = new System.Drawing.Size(189, 23);
            this.descriereTxtBox.TabIndex = 8;
            // 
            // nrMinTxtBox
            // 
            this.nrMinTxtBox.Location = new System.Drawing.Point(363, 129);
            this.nrMinTxtBox.Name = "nrMinTxtBox";
            this.nrMinTxtBox.Size = new System.Drawing.Size(189, 23);
            this.nrMinTxtBox.TabIndex = 9;
            // 
            // timpExpirareTxtBox
            // 
            this.timpExpirareTxtBox.Location = new System.Drawing.Point(363, 226);
            this.timpExpirareTxtBox.Name = "timpExpirareTxtBox";
            this.timpExpirareTxtBox.Size = new System.Drawing.Size(189, 23);
            this.timpExpirareTxtBox.TabIndex = 11;
            // 
            // oraComboBox
            // 
            this.oraComboBox.FormattingEnabled = true;
            this.oraComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.oraComboBox.Location = new System.Drawing.Point(363, 194);
            this.oraComboBox.Name = "oraComboBox";
            this.oraComboBox.Size = new System.Drawing.Size(189, 23);
            this.oraComboBox.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 12);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(75, 31);
            this.inapoiBtn.TabIndex = 14;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(539, 374);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(105, 34);
            this.adaugaBtn.TabIndex = 15;
            this.adaugaBtn.Text = "Adauga";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // ActivitateNouaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 420);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.oraComboBox);
            this.Controls.Add(this.timpExpirareTxtBox);
            this.Controls.Add(this.nrMinTxtBox);
            this.Controls.Add(this.descriereTxtBox);
            this.Controls.Add(this.profiComboBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActivitateNouaForm";
            this.Text = "ActivitateNouaForm";
            this.Load += new System.EventHandler(this.ActivitateNouaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox profiComboBox;
        private System.Windows.Forms.TextBox descriereTxtBox;
        private System.Windows.Forms.TextBox nrMinTxtBox;
        private System.Windows.Forms.TextBox timpExpirareTxtBox;
        private System.Windows.Forms.ComboBox oraComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button inapoiBtn;
        private System.Windows.Forms.Button adaugaBtn;
    }
}