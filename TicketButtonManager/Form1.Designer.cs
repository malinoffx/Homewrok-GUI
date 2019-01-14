namespace TicketButtonManager
{
    partial class Form1
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
            this.Bileti = new System.Windows.Forms.TextBox();
            this.Detski = new System.Windows.Forms.RadioButton();
            this.Uchenici = new System.Windows.Forms.RadioButton();
            this.Studenti = new System.Windows.Forms.RadioButton();
            this.Presmetni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bileti
            // 
            this.Bileti.Location = new System.Drawing.Point(40, 32);
            this.Bileti.Name = "Bileti";
            this.Bileti.Size = new System.Drawing.Size(100, 20);
            this.Bileti.TabIndex = 0;
            this.Bileti.TextChanged += new System.EventHandler(this.Bileti_TextChanged);
            // 
            // Detski
            // 
            this.Detski.AutoSize = true;
            this.Detski.Location = new System.Drawing.Point(40, 69);
            this.Detski.Name = "Detski";
            this.Detski.Size = new System.Drawing.Size(101, 17);
            this.Detski.TabIndex = 1;
            this.Detski.TabStop = true;
            this.Detski.Text = "Children - 3 leva";
            this.Detski.UseVisualStyleBackColor = true;
            this.Detski.CheckedChanged += new System.EventHandler(this.Detski_CheckedChanged);
            // 
            // Uchenici
            // 
            this.Uchenici.AutoSize = true;
            this.Uchenici.Location = new System.Drawing.Point(40, 93);
            this.Uchenici.Name = "Uchenici";
            this.Uchenici.Size = new System.Drawing.Size(108, 17);
            this.Uchenici.TabIndex = 2;
            this.Uchenici.TabStop = true;
            this.Uchenici.Text = "Students - 4 leva.";
            this.Uchenici.UseVisualStyleBackColor = true;
            this.Uchenici.CheckedChanged += new System.EventHandler(this.Uchenici_CheckedChanged);
            // 
            // Studenti
            // 
            this.Studenti.AutoSize = true;
            this.Studenti.Location = new System.Drawing.Point(40, 117);
            this.Studenti.Name = "Studenti";
            this.Studenti.Size = new System.Drawing.Size(146, 17);
            this.Studenti.TabIndex = 3;
            this.Studenti.TabStop = true;
            this.Studenti.Text = "College Students - 5 leva.";
            this.Studenti.UseVisualStyleBackColor = true;
            this.Studenti.CheckedChanged += new System.EventHandler(this.Studenti_CheckedChanged);
            // 
            // Presmetni
            // 
            this.Presmetni.Location = new System.Drawing.Point(40, 140);
            this.Presmetni.Name = "Presmetni";
            this.Presmetni.Size = new System.Drawing.Size(75, 23);
            this.Presmetni.TabIndex = 4;
            this.Presmetni.Text = "Calculate!";
            this.Presmetni.UseVisualStyleBackColor = true;
            this.Presmetni.Click += new System.EventHandler(this.Presmetni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(37, 183);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(13, 13);
            this.Label.TabIndex = 6;
            this.Label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 247);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Presmetni);
            this.Controls.Add(this.Studenti);
            this.Controls.Add(this.Uchenici);
            this.Controls.Add(this.Detski);
            this.Controls.Add(this.Bileti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bileti;
        private System.Windows.Forms.RadioButton Detski;
        private System.Windows.Forms.RadioButton Uchenici;
        private System.Windows.Forms.RadioButton Studenti;
        private System.Windows.Forms.Button Presmetni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
    }
}

