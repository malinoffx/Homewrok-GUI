namespace CarAuto
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
            this.Pic = new System.Windows.Forms.PictureBox();
            this.Mustang = new System.Windows.Forms.RadioButton();
            this.Dodge = new System.Windows.Forms.RadioButton();
            this.Cheve = new System.Windows.Forms.RadioButton();
            this.Abs = new System.Windows.Forms.CheckBox();
            this.Fog = new System.Windows.Forms.CheckBox();
            this.Chains = new System.Windows.Forms.CheckBox();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.Card = new System.Windows.Forms.RadioButton();
            this.Check = new System.Windows.Forms.RadioButton();
            this.Cena = new System.Windows.Forms.Label();
            this.Extri = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.Obsht = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic
            // 
            this.Pic.Image = global::CarAuto.Properties.Resources.car3;
            this.Pic.Location = new System.Drawing.Point(269, 35);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(417, 244);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            // 
            // Mustang
            // 
            this.Mustang.AutoSize = true;
            this.Mustang.Location = new System.Drawing.Point(6, 19);
            this.Mustang.Name = "Mustang";
            this.Mustang.Size = new System.Drawing.Size(90, 17);
            this.Mustang.TabIndex = 1;
            this.Mustang.TabStop = true;
            this.Mustang.Text = "Ford Mustang";
            this.Mustang.UseVisualStyleBackColor = true;
            this.Mustang.CheckedChanged += new System.EventHandler(this.Mustang_CheckedChanged);
            // 
            // Dodge
            // 
            this.Dodge.AutoSize = true;
            this.Dodge.Location = new System.Drawing.Point(7, 42);
            this.Dodge.Name = "Dodge";
            this.Dodge.Size = new System.Drawing.Size(97, 17);
            this.Dodge.TabIndex = 2;
            this.Dodge.TabStop = true;
            this.Dodge.Text = "Dodge Charger";
            this.Dodge.UseVisualStyleBackColor = true;
            this.Dodge.CheckedChanged += new System.EventHandler(this.Dodge_CheckedChanged);
            // 
            // Cheve
            // 
            this.Cheve.AutoSize = true;
            this.Cheve.Location = new System.Drawing.Point(7, 65);
            this.Cheve.Name = "Cheve";
            this.Cheve.Size = new System.Drawing.Size(109, 17);
            this.Cheve.TabIndex = 3;
            this.Cheve.TabStop = true;
            this.Cheve.Text = "Chevrolet Camaro";
            this.Cheve.UseVisualStyleBackColor = true;
            this.Cheve.CheckedChanged += new System.EventHandler(this.Cheve_CheckedChanged);
            // 
            // Abs
            // 
            this.Abs.AutoSize = true;
            this.Abs.Location = new System.Drawing.Point(6, 19);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(47, 17);
            this.Abs.TabIndex = 4;
            this.Abs.Text = "ABS";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.CheckedChanged += new System.EventHandler(this.Abs_CheckedChanged);
            // 
            // Fog
            // 
            this.Fog.AutoSize = true;
            this.Fog.Location = new System.Drawing.Point(6, 42);
            this.Fog.Name = "Fog";
            this.Fog.Size = new System.Drawing.Size(75, 17);
            this.Fog.TabIndex = 5;
            this.Fog.Text = "Fog Lights";
            this.Fog.UseVisualStyleBackColor = true;
            this.Fog.CheckedChanged += new System.EventHandler(this.Fog_CheckedChanged);
            // 
            // Chains
            // 
            this.Chains.AutoSize = true;
            this.Chains.Location = new System.Drawing.Point(6, 64);
            this.Chains.Name = "Chains";
            this.Chains.Size = new System.Drawing.Size(58, 17);
            this.Chains.TabIndex = 6;
            this.Chains.Text = "Chains";
            this.Chains.UseVisualStyleBackColor = true;
            this.Chains.CheckedChanged += new System.EventHandler(this.Chains_CheckedChanged);
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(6, 19);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(49, 17);
            this.Cash.TabIndex = 7;
            this.Cash.TabStop = true;
            this.Cash.Text = "Cash";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.CheckedChanged += new System.EventHandler(this.Cash_CheckedChanged);
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(6, 42);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(77, 17);
            this.Card.TabIndex = 8;
            this.Card.TabStop = true;
            this.Card.Text = "Credit Card";
            this.Card.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(6, 68);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(56, 17);
            this.Check.TabIndex = 9;
            this.Check.TabStop = true;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(12, 84);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(13, 13);
            this.Cena.TabIndex = 10;
            this.Cena.Text = "1";
            this.Cena.Click += new System.EventHandler(this.Cena_Click);
            // 
            // Extri
            // 
            this.Extri.AutoSize = true;
            this.Extri.Location = new System.Drawing.Point(6, 84);
            this.Extri.Name = "Extri";
            this.Extri.Size = new System.Drawing.Size(13, 13);
            this.Extri.TabIndex = 11;
            this.Extri.Text = "2";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(28, 338);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 12;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Obsht
            // 
            this.Obsht.AutoSize = true;
            this.Obsht.Location = new System.Drawing.Point(269, 286);
            this.Obsht.Name = "Obsht";
            this.Obsht.Size = new System.Drawing.Size(13, 13);
            this.Obsht.TabIndex = 13;
            this.Obsht.Text = "3";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(469, 286);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(13, 13);
            this.Discount.TabIndex = 14;
            this.Discount.Text = "4";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(630, 286);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(13, 13);
            this.Total.TabIndex = 15;
            this.Total.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cash);
            this.groupBox1.Controls.Add(this.Card);
            this.groupBox1.Controls.Add(this.Check);
            this.groupBox1.Location = new System.Drawing.Point(28, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Method";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Abs);
            this.groupBox2.Controls.Add(this.Fog);
            this.groupBox2.Controls.Add(this.Chains);
            this.groupBox2.Controls.Add(this.Extri);
            this.groupBox2.Location = new System.Drawing.Point(28, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 113);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Mustang);
            this.groupBox3.Controls.Add(this.Dodge);
            this.groupBox3.Controls.Add(this.Cheve);
            this.groupBox3.Controls.Add(this.Cena);
            this.groupBox3.Location = new System.Drawing.Point(28, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Obsht);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Pic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.RadioButton Mustang;
        private System.Windows.Forms.RadioButton Dodge;
        private System.Windows.Forms.RadioButton Cheve;
        private System.Windows.Forms.CheckBox Abs;
        private System.Windows.Forms.CheckBox Fog;
        private System.Windows.Forms.CheckBox Chains;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.RadioButton Card;
        private System.Windows.Forms.RadioButton Check;
        private System.Windows.Forms.Label Cena;
        private System.Windows.Forms.Label Extri;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label Obsht;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

