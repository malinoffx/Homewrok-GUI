namespace ClickButton
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
            this.TouchMe = new System.Windows.Forms.Button();
            this.TouchforReset = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TouchMe
            // 
            this.TouchMe.Location = new System.Drawing.Point(94, 35);
            this.TouchMe.Name = "TouchMe";
            this.TouchMe.Size = new System.Drawing.Size(75, 23);
            this.TouchMe.TabIndex = 0;
            this.TouchMe.Text = "Touch me.";
            this.TouchMe.UseVisualStyleBackColor = true;
            this.TouchMe.Click += new System.EventHandler(this.TouchMe_Click);
            // 
            // TouchforReset
            // 
            this.TouchforReset.Location = new System.Drawing.Point(94, 91);
            this.TouchforReset.Name = "TouchforReset";
            this.TouchforReset.Size = new System.Drawing.Size(75, 23);
            this.TouchforReset.TabIndex = 1;
            this.TouchforReset.Text = "Reset.";
            this.TouchforReset.UseVisualStyleBackColor = true;
            this.TouchforReset.Click += new System.EventHandler(this.TouchforReset_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(125, 145);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(13, 13);
            this.Label.TabIndex = 2;
            this.Label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 242);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TouchforReset);
            this.Controls.Add(this.TouchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TouchMe;
        private System.Windows.Forms.Button TouchforReset;
        private System.Windows.Forms.Label Label;
    }
}

