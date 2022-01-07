
namespace Pro1
{
    partial class ProgrameazaForm
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
            this.CursComboBox = new System.Windows.Forms.ComboBox();
            this.ActComboBox = new System.Windows.Forms.ComboBox();
            this.ZiComboBox = new System.Windows.Forms.ComboBox();
            this.PondereTrackBar = new System.Windows.Forms.TrackBar();
            this.incepereDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finalizareDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.oraComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTrackBar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nrStudTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PondereTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(182, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(182, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(182, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pondere";
            // 
            // CursComboBox
            // 
            this.CursComboBox.FormattingEnabled = true;
            this.CursComboBox.Location = new System.Drawing.Point(366, 48);
            this.CursComboBox.Name = "CursComboBox";
            this.CursComboBox.Size = new System.Drawing.Size(185, 23);
            this.CursComboBox.TabIndex = 5;
            // 
            // ActComboBox
            // 
            this.ActComboBox.FormattingEnabled = true;
            this.ActComboBox.Items.AddRange(new object[] {
            "Curs",
            "Seminar",
            "Laborator",
            "Colocviu",
            "Examen"});
            this.ActComboBox.Location = new System.Drawing.Point(366, 77);
            this.ActComboBox.Name = "ActComboBox";
            this.ActComboBox.Size = new System.Drawing.Size(185, 23);
            this.ActComboBox.TabIndex = 6;
            // 
            // ZiComboBox
            // 
            this.ZiComboBox.FormattingEnabled = true;
            this.ZiComboBox.Items.AddRange(new object[] {
            "Luni",
            "Marti",
            "Miercuri",
            "Joi",
            "Vineri",
            "Sambata",
            "Duminica"});
            this.ZiComboBox.Location = new System.Drawing.Point(366, 135);
            this.ZiComboBox.Name = "ZiComboBox";
            this.ZiComboBox.Size = new System.Drawing.Size(185, 23);
            this.ZiComboBox.TabIndex = 7;
            // 
            // PondereTrackBar
            // 
            this.PondereTrackBar.Location = new System.Drawing.Point(366, 164);
            this.PondereTrackBar.Name = "PondereTrackBar";
            this.PondereTrackBar.Size = new System.Drawing.Size(185, 45);
            this.PondereTrackBar.TabIndex = 8;
            this.PondereTrackBar.Scroll += new System.EventHandler(this.PondereTrackBar_Scroll);
            // 
            // incepereDateTimePicker1
            // 
            this.incepereDateTimePicker1.Location = new System.Drawing.Point(351, 215);
            this.incepereDateTimePicker1.Name = "incepereDateTimePicker1";
            this.incepereDateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.incepereDateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(167, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data incepere";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(167, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data finalizare";
            // 
            // finalizareDateTimePicker1
            // 
            this.finalizareDateTimePicker1.Location = new System.Drawing.Point(351, 244);
            this.finalizareDateTimePicker1.Name = "finalizareDateTimePicker1";
            this.finalizareDateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.finalizareDateTimePicker1.TabIndex = 12;
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
            "20"});
            this.oraComboBox.Location = new System.Drawing.Point(366, 106);
            this.oraComboBox.Name = "oraComboBox";
            this.oraComboBox.Size = new System.Drawing.Size(184, 23);
            this.oraComboBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salveaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTrackBar
            // 
            this.labelTrackBar.AutoSize = true;
            this.labelTrackBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrackBar.Location = new System.Drawing.Point(568, 164);
            this.labelTrackBar.Name = "labelTrackBar";
            this.labelTrackBar.Size = new System.Drawing.Size(0, 21);
            this.labelTrackBar.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(167, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numar maxim de studenti";
            // 
            // nrStudTextBox
            // 
            this.nrStudTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nrStudTextBox.Location = new System.Drawing.Point(365, 294);
            this.nrStudTextBox.Name = "nrStudTextBox";
            this.nrStudTextBox.Size = new System.Drawing.Size(52, 29);
            this.nrStudTextBox.TabIndex = 18;
            // 
            // ProgrameazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nrStudTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTrackBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oraComboBox);
            this.Controls.Add(this.finalizareDateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.incepereDateTimePicker1);
            this.Controls.Add(this.PondereTrackBar);
            this.Controls.Add(this.ZiComboBox);
            this.Controls.Add(this.ActComboBox);
            this.Controls.Add(this.CursComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProgrameazaForm";
            this.Text = "ProgrameazaForm";
            this.Load += new System.EventHandler(this.ProgrameazaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PondereTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CursComboBox;
        private System.Windows.Forms.ComboBox ActComboBox;
        private System.Windows.Forms.ComboBox ZiComboBox;
        private System.Windows.Forms.TrackBar PondereTrackBar;
        private System.Windows.Forms.DateTimePicker incepereDateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker finalizareDateTimePicker1;
        private System.Windows.Forms.ComboBox oraComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTrackBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nrStudTextBox;
    }
}