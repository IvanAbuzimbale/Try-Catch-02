namespace TryCatch02
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
            this.txtBrojA = new System.Windows.Forms.TextBox();
            this.txtBrojB = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrojA
            // 
            this.txtBrojA.Location = new System.Drawing.Point(12, 12);
            this.txtBrojA.Name = "txtBrojA";
            this.txtBrojA.Size = new System.Drawing.Size(105, 20);
            this.txtBrojA.TabIndex = 0;
            // 
            // txtBrojB
            // 
            this.txtBrojB.Location = new System.Drawing.Point(12, 54);
            this.txtBrojB.Name = "txtBrojB";
            this.txtBrojB.Size = new System.Drawing.Size(105, 20);
            this.txtBrojB.TabIndex = 1;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(12, 94);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(105, 20);
            this.txtIspis.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(166, 22);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(102, 82);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtBrojB);
            this.Controls.Add(this.txtBrojA);
            this.Name = "Form1";
            this.Text = "Try_Catch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojA;
        private System.Windows.Forms.TextBox txtBrojB;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnPlus;
    }
}

