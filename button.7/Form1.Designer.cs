namespace button._7
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
            this.btnyaz = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnyaz
            // 
            this.btnyaz.Location = new System.Drawing.Point(43, 38);
            this.btnyaz.Name = "btnyaz";
            this.btnyaz.Size = new System.Drawing.Size(112, 118);
            this.btnyaz.TabIndex = 0;
            this.btnyaz.Text = "YAZ";
            this.btnyaz.UseVisualStyleBackColor = true;
            this.btnyaz.Click += new System.EventHandler(this.btnyaz_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(43, 197);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(112, 118);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(221, 163);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(142, 20);
            this.txt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnyaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyaz;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txt;
    }
}

